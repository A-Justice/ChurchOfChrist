   M S B A M L   `   `   `  ����D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  5      S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  5
      W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  5      E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  5      '    !ShortBody.Pages.PaymentAdvicePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ShortBody.Pages     5      W SMaterialDesignThemes.Wpf, Version=1.2.0.31861, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5	   
   8ctr.clr-namespace:ShortBody.Resources.UserControls  5
      9an0clr-namespace:ShortBody.Resources.Helper_Methods  5      0cv'clr-namespace:ShortBody.ValueConverters  5        N� Title$  PaymentAdvicePage��5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��7 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��2��6   $��	20,5,20,5q�6#   $��40��66      MaterialDesignPaper#���   5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��5,0,5,0q�5       .+�5"      �� $��
SearchBy :��6   $��Center=�6.   $��17(�5#      �� 5$      -   5        $��cboSearchBox��5$      $	��150��6`   $��Center=�6l   $��5,0,5,0q�5%   5    �� Text 6   �� *
SearchBy+@�5&      �� 5'      $	��All��6'   �� 5(      $��Company Name��6'   �� 5)      $��Cheque #��6'   5+      �� 5-      -   5        $��txtSearchBox��5-      $	��150��6/   $��10,0,5,0q�6;   ��6M   �� *SearchString+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5/        BoderlessButton#��[ 6   $��17(�50      $��5,0,5,0q�6(   ��51      �� *SearchPaymentAdviceCommand+.��6I   Search53      54      55      1   +ShortBody.Resources.UserControls.miniWindow  58   
   
������    
HeaderText$ 
Payment Ad��63   $��1��59      $��3��6&      CanClose .  	   Content	 5;      � 5<       5=      �� 5>      $
��auto �6(   �� 5?      $
��241* �6(   .+�5A      �� $ 
Horizontal=�6!     myDirtyWhite#��[ 5B      .+�5C      �� -   5        $��5q�5C   "   
 � ToolTip$
 Add New Payment Advice��6-     b_Button#��[ 5D      ��5E   E   �� *AddPaCommand+.��6f   Add Payment Advice5G      �� 5H      
�������$��1��61   $��5,5,5,5q�6;   �� 5J      $��1,5,5,5q�6"   #��[ 63   $��Delete Payment Advice��5K   "   ��5L   "   �� *DeletePaCommand+�� 5N      -   5        $��1,5,5,5q�5N   "   #��[ 63   $��View Payment Advice��5Q   "   ��5R   "   �� *ViewPaCommand+5V      &   System.Windows.Controls.DataGrid  5X      -   5        $��1��5X         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6I      CanUserAddRows .    defaultHeaderStyle   ColumnHeaderStyle# [ 5Z   ,   ��5Y   B   �� *PaymentAdvices+   Columns 5]      9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  5^      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� *Date+ �� 	Converter -  'ShortBody.ValueConverters.DateFormatter  6�     5_      $ ChequeNumber��6<    6R   �� *ChequeNumber+6u     5`      $ CompanyName��6<    6Q   �� *CompanyName+6s     5a      $ BankName��6<    6N   �� *
BankName+6m     5b      $ Vat Rate��6<    6N   �� *	VatRate+6l     5c      $ 	Vat Value��6<    6O   �� *
VatValue+ -   'ShortBody.ValueConverters.DToSConverter  6�     5d      $ TotalAmount��6<    6Q   �� *TotalAmount+   6�     5e      $ IssuedBy��6<    6N   �� *
IssuedBy+   6�   5i      5j      5l        5n   
   -   5          Name$ AddPaymentAdvice��5o      1	   +ShortBody.Resources.UserControls.miniWindow 	  Loaded$ AddPaymentAdvice_Loaded��5p      $��1��5n      $��1��6&   $ Add Payment Advice��66   $	��600��5o   3   $	��300��6?   .	 5r      �  5s      �� 5t      $
��auto �6$   �� 5u      $
��241* �6$   �� 5v      $��10 �6$   .+�5x      �� $ 
Horizontal=�6   #��[ 5y      .+�5{      �� $��10,5,5,5q�6   #��[ 60   $
 Clear Boxes��5|      $	��CPA��5}      ��5|   4   �� *
ClearBoxes+.��5~      �� $ 
Horizontal=�6%   .+�5      "
  FontAwesome.WPF.ImageAwesome
   
  Icon$ 
PaintBrush=�6.   $��20��6@   5�      5�      �� 5�      
�������$��1��6-   $��5,5,1,5q�67   5�      � 5�      $��1��6   $��2��6$   #���   65    � DataContext 5�      �� *NewPaymentAdvice+ 5�      �� 5�      $��8* �6(   �� 5�      $	��55* �6(    5�      �� 5�      $
��Auto �6+   �� 5�      $��* �6+   �� 5�      $
��Auto �6+   �� 5�      $��* �6+   .+�5�      ��   tb#��[ 6    $��5q�6w    �� TextAlignment$ Center=�5�   $   ���#CA5100$��4��6P   ��5�   <   �� *Error+$ PropertyChanged=� 5�   $   ��  �� RelativeSource ��  �� AncestorType" >� �� Mode$ FindAncestor=� �� Path$ DataContext��� 5�      $��5q�6!   $��1��6,   .+�5�      �� #��[ 6$   $��Bank :��6@   $ Right=�6N   $��10q�6d   $��Center=�5�   $   �� 5�      #��[ 6$   $��Cheque Number :��6@   $ Right=�6W   $��10q�6m   $��Center=�5�   $   5�      �� 5�      $��1��6!   $��5q�61   $��1��6<   .+�5�      �� $��	5,10,5,10q�6=   ��6"   �� *
BankName+6=   �� 5�      $��	5,10,5,10q�6A   ��6"   �� *ChequeNumber+6A   5�      �� 5�      $��2��6!   $��5q�61   $��1��6<   .+�5�      �� #��[ 6$   $��Client Name :��6@   $ Right=�6U   $��10q�6k   $��Center=�5�   $   �� 5�      #��[ 6$   $��
Vat_Nhil :��6@   $ Right=�6R   $��10q�6h   $��Center=�5�   $   5�      �� 5�      $��3��6!   $��5q�61   $��1��6<   .+�5�      �� $��	5,10,5,10q�5�   "   ��5�   "   �� *CompanyName+$ PropertyChanged=�$ TwoWay=�5�   "   �� 5�      $��	5,10,5,10q�6<   ��6"   �� *	VatRate+6<   �� 5�      $
��Save��6!   $��50��5�   N    5�   0   ��  �� "  $ FindAncestor=�$ DataContext���5�   !   �� *SavePaymentAdviceCommand+6N   5�      5�      5�      5�      5�      5�      