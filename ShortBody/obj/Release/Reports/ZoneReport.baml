   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ShortBody.ReportsShortBody.Reports  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  "    ShortBody.Reports.ZoneReport   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:ShortBody.Reports     >win.clr-namespace:ShortBody.Resources.UserControls     6cv'clr-namespace:ShortBody.ValueConverters     -     � WindowState$  	Maximized=� � Title$ 
ZoneReport��$	��450��$	��800��.��� .+�6   0ShortBody.Resources.UserControls.DocumentControl  -     Name$ ZoneDocumentControl��.���� .+��� $��10q�._���  �� Orientation$ 
Horizontal=�$��Center=�.+��� -   $
��Bold"�$��18(�$��5q�$��All Reports���� $
��Bold"�$��18(�$��5q����� *Type+�� -   $ 
Horizontal=�.+��� $
��Bold"�$��18(�$��
Report For��$��5q��� $
��Bold"�$��18(�$��5q����� *Month+ �� 	Converter 3   -ShortBody.ValueConverters.IntToMonthConverter  y��� *Month+ <   6ShortBody.ValueConverters.ContentToVisibilityConverter  �� $
��Bold"�$��18(�$��5q����� *Year+�� -   $ 
Horizontal=�.+��� $
��Bold"�$��18(�$��
Report For��$��5q��� $
��Bold"�$��18(�$��5q����� *Half+�� $
��Bold"�$��18(�$��Half of��$��5q��� $
��Bold"�$��18(�$��5q����� *Year+�� -   $ 
Horizontal=�.+��� $
��Bold"�$��18(�$��
Report For��$��5q��� $
��Bold"�$��18(�$��5q����� *	Quarter+�� $
��Bold"�$��18(�$��
Quarter of��$��5q��� $
��Bold"�$��18(�$��5q����� *Year+�� $��Center=�$��	10,5,10,5q�   DeepBlue#��[  $��2q�._��� $��Center=�$ 
Horizontal=�.+��� $��ZONE LEADER �����#F7F4F7 �� Padding$ 5q�$��5q��� $��5q�$ 5q�$
��Bold"����#CA5100���� *Zone.ZoneLeaderId+ 3   -ShortBody.ValueConverters.IdToPersonConverter  &   System.Windows.Controls.DataGrid     CanUserAddRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    AutoGenerateColumns .  ���� *Report+	 �� 
GroupStyle	 (  "System.Windows.Controls.GroupStyle  
   HeaderTemplate
 �� .R��� .+��� ���� *Name+   ContainerStyle ��  �� 
TargetType" ��.���  �� Property � �� �� Value ��  �� 
TargetType" ��.R�9�  9� 
IsExpanded . ���� $��Center=�$ 
Horizontal=�
����ح�.+��� $	��200�����#CA5100$
��Bold"�$ 5q�$��10,10,10,10q����� *Name.AreaName+�� $��	10,5,10,5q�#��[  $��2q�#��[  ._��� $ 
Horizontal=�.+��� $��Area Leader �����#F7F4F7$ 5q�$��5q��� $��5q�$ 5q�$
��Bold"����#F7F4F7���� *Name.AreaLeaderId+   �� $��	10,5,10,5q�#��[  $��2q�#��[  ._��� $ 
Horizontal=�.+��� $ 5q�$��Number of People�����#F7F4F7$��5q��� $ 5q�$��5q�$
��Bold"����#F7F4F7���� *	ItemCount+.����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,	  &System.Windows.Controls.DataGridColumn 	  Width$ 60  	  Header$ Id��1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding �� *Person.PersonId+  $
 Name�� �� *Person.FullName+  $	 150 $ Phone�� �� *Person.Phone+  $ 60 $	 Sun�� �� *	Sundays+  $ 60 $	 Tue�� �� *
Tuesdays+  $ 60 $	 Fri�� �� *	Fridays+  $	 120 $ 	Sum Total�� �� *Total+  $ Remarks�� �� *Remark+   RowStyle �� )  #System.Windows.Controls.DataGridRow"  .���  � �� �� *Person.Group.Name+ 6   0ShortBody.ValueConverters.RowBackgroundConverter  