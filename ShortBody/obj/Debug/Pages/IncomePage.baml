   M S B A M L   `   `   `  ����D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  5      1clr-namespace:ShortBody.PagesShortBody.Pages  5      S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  5	      E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  5           ShortBody.Pages.IncomePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?an0clr-namespace:ShortBody.Resources.Helper_Methods     5      /localclr-namespace:ShortBody.Pages     5      >ctr.clr-namespace:ShortBody.Resources.UserControls     5	      W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  5
      0cv'clr-namespace:ShortBody.ValueConverters  5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      .��5      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��7 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��2��6   $��	20,5,20,5q�6#   $��40��66      MaterialDesignPaper#���   5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��5,0,5,0q�5       .+�5"      �� $��
SearchBy :��6   $��Center=�6.   $��17(�5#      �� 5$      -   5        $��cboSearchBox��5%      $	��150��5$      $��Center=�6'   $��5,0,5,0q�5&   5    �� Text 6   �� *
SearchBy+@�5'      �� 5(      $	��All��6'   �� 5)      $��Cheque #��6'   �� 5*      $��Payee��6'   5,      �� 5.      -   5        $��txtSearchBox��5.      $	��150��6/   $��10,0,5,0q�6;   ��6M   �� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 50        BoderlessButton#��[ 6   $��17(�51      $��5,0,5,0q�6(   ��52      �� *SearchIncomeCommand+.��6B   Search54      55      56      1   +ShortBody.Resources.UserControls.miniWindow  59   
   
������    
HeaderText$ All Incomes��63   $��1��5:      $��3��6&      CanClose .     Content 5<      � 5=        5>      �� 5?      $
��auto �6(   �� 5@      $
��241* �6(   �� 5A      $��10 �6(   .+�5C      �� $ 
Horizontal=�6!     myDirtyWhite#��[ 5D      .+�5E      �� -   5        $��5q�5E   "   	 � ToolTip$	 Add New Income��6-     b_Button#��[ 5F      .��5G      "  FontAwesome.WPF.ImageAwesome  
   Icon$
 UserPlus=�6.   $��20��6>   5H      �� 5I      
�������$��1��61   $��5,5,1,5q�6;   �� 5K      $��1,5,5,5q�6"   #��[ 63   ��6U   �� *DeleteIncomeCommand+.��5L      �� $ 
Horizontal=�6)   $	 Delete Income��6B   .+�5M   "     $
 Trash=�62   $��20��6?   5O      5P      �� 5R      
�������$��1��61   $��5,5,1,5q�6;   �� 5T      -   5        $��1,5,5,5q�5T   "   #��[ 63   $��Income Statement��6r   5Y      &   System.Windows.Controls.DataGrid  5[      -   5        ��.     AutoGenerateColumns .  
���   �   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5\      $��1��60   $��2��6=      CanUserAddRows .     CanUserReorderColumns .    CanUserResizeColumns .    CanUserResizeRows .     CanUserSortColumns . $��13(�5^   ?   ��5[   b   �� *
AllIncomes+$ PropertyChanged=�$ OneWay=�   Columns 5_      9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  5`      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� *Date+ �� 	Converter -  'ShortBody.ValueConverters.DateFormatter  6�     5a      $ Payee��6<    6K   �� *Payee+6g     5b      $ ChequeNumber��6<    6R   �� *ChequeNumber+6u     5c      $ Amount��6<    6L   �� *Amount+ -	   'ShortBody.ValueConverters.DToSConverter	  6�   5f      5g      5i        5k   
   -   5          Name$ AddIncomeWindow��5l      1
   +ShortBody.Resources.UserControls.miniWindow 
  Loaded$ AddIncomeWindow_Loaded��5m      $��1��5k      $��1��6&   $ Add New Income��66   $	��600��5l   2   . 5n      �   5o      �� 5p      $
��auto �6$   �� 5q      $
��241* �6$   �� 5r      $��10 �6$   .+�5t      �� $ 
Horizontal=�6   #��[ 5u      .+�5w      �� $��10,5,5,5q�6   #��[ 60   $	 Clear Boxes��5x      ��64   �� *
ClearBoxes+.��5y      �� $ 
Horizontal=�6%   .+�5z        $
 
PaintBrush=�6.   $��20��6@   5|      5}      �� 5      
�������$��1��6-   $��5,5,1,5q�67   5�      � 5�      $��1��6   $��2��6$   #���   65    � DataContext 6h   �� *	NewIncome+  5�      �� 5�      $��8* �6(   �� 5�      $	��55* �6(    5�      �� 5�      $
��Auto �6+   �� 5�      $��* �6+   �� 5�      $
��Auto �6+   �� 5�      $��* �6+   .+�5�      ��   tb#��[ 6    $��5q�6w    �� TextAlignment$ Center=�5�   $   ���#CA5100$��4��6P   ��5�   <   �� *Error+$ PropertyChanged=� 5�   $   ��  �� RelativeSource ��  �� AncestorType" >� �� Mode$ FindAncestor=� �� Path$ DataContext��� 5�      $��5q�6!   $��1��6,   .+�5�      �� #��[ 6$   $��Payee :��6@   $ Right=�6O   $��10q�6e   $��Center=�5�   $   5�      �� 5�      $��1��6!   $��5q�61   $��1��6<   .+�5�      �� $��	5,10,5,10q�6:   ��6"   �� *Payee+6:   5�      �� 5�      $��2��6!   $��5q�61   $��1��6<   .+�5�      �� #��[ 6$   $��Cheque Number :��6@   $ Right=�6W   $��10q�6m   $��Center=�5�   $   �� 5�      #��[ 6$   $��Amount :��6@   $ Right=�6P   $��10q�6f   $��Center=�5�   $   5�      �� 5�      $��3��6!   $��5q�61   $��1��6<   .+�5�      �� $��	5,10,5,10q�6A   ��6"   �� *ChequeNumber+6A   �� 5�      $��	5,10,5,10q�6;   ��6"   �� *Amount+6;   �� 5�      $
��Save��6!   $��50��5�   G    5�   0   ��  �� "  $ FindAncestor=�$ DataContext���5�   !   �� *SaveIncomeCommand+6G   5�      5�      5�      5�      5�      5�      