   M S B A M L   `   `   `  ����D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ShortBody.ReportsShortBody.Reports  5   	   W0clr-namespace:ShortBody.Resources.Helper_Methods"ShortBody.Resources.Helper_Methods  5      E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  5   	   %    ShortBody.Reports.PaymentAdvice   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ShortBody.Reports     5   	   ?an0clr-namespace:ShortBody.Resources.Helper_Methods     5      6cv'clr-namespace:ShortBody.ValueConverters     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5	   	   -   5          � Icon$4  ./ShortBody;component/Resources/Images/icon.ico��5
   4    � Title$ PaymentAdvice��5   	   $	��800��6   $	��900��6,    � 	Resources 5       �� 
TargetType   MaterialDesignTextBox �� BasedOn �� Property �� Value��%�   '��       7   �� 5   
   " ��6   8   .�5      ��  � ��$ 14(�6)   �� 5       � ��$ Arial)�6+   �� 5       � ��$ 0q�60   5      5      .��5      � $	��900��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��TopPanel��5   9    �� Orientation$ 
Horizontal=�6   $��5q�6.   .+�5      �� -   5        .��5      "  FontAwesome.WPF.ImageAwesome  	   Icon$	 Print=�6"   $��40��6/   $��5q�6:   
 � ToolTip$
 Print��6E   5      5       ,� 5#   
   -   5        $��document��5#   0   $��1��6#   .��5$      /�  /� ColumnWidth$	 500��6   .T�5%      �� .r�5&      �  5'      �� 5(      $
��auto �6,   �� 5)      $��* �6,   �� 5*      $
��auto �6,   �� 5+      $
��auto �6,   �� 5,      $
��auto �6,   .+�5/      �� $ 
Horizontal=�6%   $��Center=�6>    � DataContext 50      �� *SelectedCompany+.+�51      �� $	��100��6$   $	��100��61   $��0,0,20,0q�6=   ��6O   �� *Logo+ �� 	Converter 4   .ShortBody.ValueConverters.ByteToImageConverter  �� 52      $��20,0,0,0q�6)   .+�54   "   �� $��	ExtraBold"�6@   $��
20,0,20,20q�6W   $��16(�55   *   ��54   *   �� *Name+55   *   �� 56   "   $ 
Horizontal=�6-   .+�57   &   �� $��5q�61   .+�58   *   �� $��	Address :��62    �� TextAlignment$ Right=�6C   �� 59   *   $��Phone :��62   $ Right=�6A   �� 5:   *   $��Email :��62   $ Right=�6A   5;   '   �� 5<   &   $��5q�61   $	��200��6<   .+�5=   *   �� $ Center=�6o   ��62   �� *	Address+ �� UpdateSourceTrigger$ PropertyChanged=�6o   �� 5>   *   $ Center=�6m   ��62   �� *Phone+$ PropertyChanged=�6m   �� 5?   *   $ Center=�6m   ��62   �� *Email+$ PropertyChanged=�6m   5@   '   5A   #   5B      5C      � 5E      $��1��6   $��	0,20,0,20q�6,    5F      �� *PaymentAdvice+$ PropertyChanged=� �� Mode$ TwoWay=� � ColumnDefinitions 5G      �� 5H   "   $��* �63   �� 5I   "   $��* �63   .+�5L      �� .+�5M   "   �� $��PAYMENT ADVICE��6,   $��Center=�6B   $��SemiBold"�6_   $��0,0,0,20q�6u   �� 5N   "   $ 
Horizontal=�6-   .+�5O   &   �� $��Company Name :��60   $��Center=�6F   �� 5P   &   $��5,0,0,0q�6.   $	��150��6@   ��6L   �� *CompanyName+$ PropertyChanged=�$ TwoWay=�5Q   #   5R      �� 5T      $��1��6)   $��Right=�69   .+�5U   "   �� $ 
Horizontal=�6-   .+�5V   &   �� $��Date :��61   $��80��6?    �� TextAlignment$ Right=�6J   $��Center=�6`   �� 5W   &   $��5,0,0,0q�6.   $	��150��6?   ��6K   �� *Date+$ PropertyChanged=�$ TwoWay=�5X   #   �� 5Y   "   $ 
Horizontal=�6-   .+�5Z   &   �� $��80��60   $ Right=�6;   $��	Cheque #:��6Q   $��Center=�6b   �� 5[   &   $��5,0,0,0q�6.   $	��150��6@   ��6L   �� *ChequeNumber+$ PropertyChanged=�$ TwoWay=�5\   #   �� 5]   "   $ 
Horizontal=�6-   .+�5^   &   �� $��80��60   $ Right=�6;   $��Bank :��6Q   $��Center=�6_   �� 5_   &   $��5,0,0,0q�6.   $	��150��6@   ��6L   �� *
BankName+$ PropertyChanged=�$ TwoWay=�5`   #   5a      5b      �� 5d      -   5        $��helperPanel��5d   g   $��2��6%   $ 
Horizontal=�62   $��Right=�6K   $��10q�5e   %    5f   -   ��  �� RelativeSource ��  �� AncestorType" � �� Mode$ FindAncestor=� �� Path$ DataContext�.+�5g      �� -   5        $��btnDeleteItem��5g   K   $
 Delete Selected Item��5h   -   ��5g   %   �� *DeleteItemCommand+.��5i   "     $	 Trash=�62   $��10��6?   5j      5k      � 5m      $��3��6    6,   �� *PaymentAdvice+$ PropertyChanged=�$ TwoWay=�.+�5n      &   System.Windows.Controls.DataGrid  -   5        $��AdvicesDataGrid��5n   '   
���   � 	 Smoke   AlternatingRowBackground# [ 5p   &    �� AlternationCount$ 2��6X   
�������   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5r   3      AutoGenerateColumns .  ��5o   '   �� *	Advices+$ PropertyChanged=�$ TwoWay=�   Columns 5s   "   0  *System.Windows.Controls.DataGridTextColumn  5t   &   ,  &System.Windows.Controls.DataGridColumn   Header$ No��69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *
AdviceId+$ PropertyChanged=�$ TwoWay=�  5u   &   $
 Date��69    6G   �� *
AdviceDate+$ PropertyChanged=�$ TwoWay=�  5v   &   $ 	Invoice #��69    6L   �� *InvoiceNumber+$ PropertyChanged=�$ TwoWay=�  5w   &   $ Description��69     elementStyle   ElementStyle# [ 6�     editingElementStyle   EditingElementStyle# [ 6�    6N   �� *Description+$ PropertyChanged=�$ TwoWay=�6�     5x   &   $ Amount(GHS)��69    6N   �� *Amount+$ PropertyChanged=�$ TwoWay=�  5y   &   $ Remarks��69    6J   �� *	Remarks+$ PropertyChanged=�$ TwoWay=�5|      5}      �� 5      $��4��6%   $��Right=�62   $��20q�6N    5�   %   �� *PaymentAdvice+$ PropertyChanged=�$ TwoWay=�.+�5�      �� $ 
Horizontal=�6)   $��2q�6B   .+�5�   "   �� $	��190��6,   $ Right=�68   $��Vat-rate (%):��6N   $��Center=�6c   �� 5�   "   -   5        $��tbVat��5�   6   $	��150��6*   $��5,0,0,0q�6C   $
 Left=�6T   ��5�   *   �� *	VatRate+$ PropertyChanged=�$ TwoWay=�5�      �� 5�      $ 
Horizontal=�6)   $��2q�6B   .+�5�   "   �� $	��190��6,   $ Right=�68   $��Vat-value (GHS) :��6O   $��Center=�6h   �� 5�   "   -	   5        $��tbVatAmount��5�   ]   $	��150��6*   $
 Left=�66   $��5,0,0,0q�6K   ��5�   *   �� *
VatValue+$ PropertyChanged=�$ TwoWay=�5�      �� 5�      $ 
Horizontal=�6)   $��2q�6B   .+�5�   "   �� $	��190��6,   $ Right=�68   $��Sub-Total (GHS) :��6O   $��Center=�6h   �� 5�   "   -
   5        $��
tbSubTotal��5�   ]   $	��150��6*   $
 Left=�66   $��5,0,0,0q�6K   ��5�   *   �� *Amount+$ PropertyChanged=�$ TwoWay=�5�      �� 5�      $ 
Horizontal=�6)   $��2q�6B   .+�5�   "   �� $	��190��6,   $
��Bold"�5�   +   $ Right=�6=   $��Total Amount (GHS) :��6S   $��Center=�6o   �� 5�   "   -   5        $��tbTotal��5�   ]   $	��150��6*   $
 Left=�66   $��5,0,0,0q�6K     �� TextDecorations$  	Underline{�5�   *   ���#CA5100��5�   *   �� *TotalAmount+$ PropertyChanged=�$ TwoWay=�5�      �� 5�      $ 
Horizontal=�6)   $��2q�6B   .+�5�   "   �� $��Issued By :��6,   $	��190��6?   $ Right=�6K   $��Center=�6b   �� 5�   "   $	��150��6*   $
 Left=�66   $��5,0,0,0q�6L   ��5�   *   �� *
IssuedBy+$ PropertyChanged=�$ TwoWay=�5�      5�      5�      5�      5�      5�      5�      5�      