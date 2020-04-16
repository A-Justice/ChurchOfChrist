using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ShortBody.Resources.Helper_Methods
{
    public class AutoHideColumn:Attribute
    {
        public AutoHideColumn()
        {

        }
    }

    public static class DataGridExtension
    {




        //public  bool HideAnnotatedColumns
        //{
        //    get { return (bool)GetValue(HideAnnotatedColumnsProperty); }
        //    set { SetValue(HideAnnotatedColumnsProperty, value); }
        //}

        // Using a DependencyProperty as the backing store for HideAnnotatedColumns.  
        //This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HideAnnotatedColumnsProperty =
            DependencyProperty.RegisterAttached("HideAnnotatedColumns", typeof(bool), typeof(DataGridExtension), new UIPropertyMetadata(false,OnHideAnnotatedColumns));


        public static bool GetHideAnnotatedColumns(DependencyObject d)
        {
            return (bool)d.GetValue(HideAnnotatedColumnsProperty);
        }

        public static void SetHideAnnotatedColumns(DependencyObject d,bool value)
        {
             d.SetValue(HideAnnotatedColumnsProperty,value);
        }


        private static void OnHideAnnotatedColumns(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            bool hideAnnotatedColumns = (bool)e.NewValue;

            DataGrid dataGrid = d as DataGrid;

            if (hideAnnotatedColumns)
            {
                dataGrid.AutoGeneratingColumn += dataGrid_AutoGeneratingColumn;
            }
            else
            {
                dataGrid.AutoGeneratingColumn -= dataGrid_AutoGeneratingColumn;
            }
        }

        private static void dataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor propertyDescriptors = e.PropertyDescriptor as PropertyDescriptor;
            if (propertyDescriptors != null)
            {
                foreach(var item in propertyDescriptors.Attributes)
                {
                    if(item.GetType() == typeof(AutoHideColumn))
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
