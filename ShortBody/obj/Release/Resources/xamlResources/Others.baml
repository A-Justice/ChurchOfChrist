   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters  S.clr-namespace:ShortBody.Resources.UserControls ShortBody.Resources.UserControls  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   btvConverter  bgImage  �� ImageSource j� TileMode  	sideImage �� 
TargetType  elementStyle �� Property �� Value  MaterialDesignTextBox �� BasedOn  editingElementStyle=   7System.Windows.Controls.Primitives.DataGridColumnHeader  defaultHeaderStyle  printOuttHeaderStyle  SubDataGridHeader&   System.Windows.Controls.DataGrid 	 MaterialDesignDataGrid*  $System.Windows.Controls.DataGridCell 
 MaterialDesignDataGridCell �� 
TargetType J� SnapsToDevicePixels �� Triggers	 P� Property
 P� Value  MaterialDesignTextBoxBorder ]� 
Conditions �� Property �� Value  MaterialDesignSelection  MaterialDesignBody  UnderlineContent �� TextDecorations  borderedCell  QuoteItemsRow)  #System.Windows.Controls.DataGridRow ��Name?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter#   RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7	  1System.Windows.Controls.DataGridHeadersVisibility
 	  Row!   HeadersVisibilityConverter  MaterialDesignDivider�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     6
converters'clr-namespace:ShortBody.ValueConverters  8local.clr-namespace:ShortBody.Resources.UserControls  %�  &	        &	      &	 4     &	 e     &	 �     7  '   �     &	 �    &	     &	 �    '  ~    7 	 7  '  �    7 
 &	     &	 +    &	 o
    �� �� $  /Resources/Images/bg.jpg��$
 Tile=��� $   /Resources/Images/side.jpg��$
 Tile=��� " ��.���  � ��$
 Wrap=��� " ��8   .���  �@��TextWrapping$
 Wrap=���  �@��AcceptsReturn . �� "   .���  � ��$ 15(���  � ��$ SemiBold"���  � ��
 �������  � �� �#3C8DBC��  � ��$ 10q���  � ��$ Center=��� "   .���  � ��$ 15(���  � ��$ SemiBold"���  � ��
 �������  � �� �#3C8DBC��  � ��$ 10q��� "   .���  � ��$ 15(���  � ��$ 63����  � ��$ SemiBold"���  � ��
 �������  � �� �#3C8DBC��  � ��$ Center=���  � ��$ 1q���  � ��$ .5q���  � ��
 �   ��� "   .���  � ��$ 15(���  � ��$ SemiBold"���  � ��
 �������  � �� �#1BA1E2��  � ��$ 10q��� "  8   .���  �@ ColumnHeaderStyle8  ��  � ��$ Arial)��� "  8   .���  � ��$ 13(���  � ��$ 10q���  � ��
 ���� ��  � ��$ Center=���  � ��
 ���� ��  � ��$ Center=���  � �� �� "  .R��� #��z��#��z��#��z�� . ._��� $��10q�$��Center=�$��Center=� P� 	 �@J�IsKeyboardFocusWithin
 . . ���  � ��# �  ]�  ��  �@ 
IsSelected . ��  �@��IsSelectionActive .  ./���  � ��# �  ]�  ��  �@ 
IsSelected . ��  �@��IsSelectionActive . ./���  � ��# �  P� 	 � {�
 .  . ���  �@J�Opacity$	 .56Q��� "  .���  � ��$ 4q���  � ��
 ���� ��  � ��
 ���� ��  � �� �� "  .R��� #��z��#��z��#��z�� . ._��� $��
MidTextBox��# z #��z��$ 	Underline{� P� 	 �@J�IsKeyboardFocusWithin
 . . ���  � ��# �  ]�  ��  �@ 
IsSelected . ��  �@��IsSelectionActive .  ./���  � ��# �  ]�  ��  �@ 
IsSelected . ��  �@��IsSelectionActive . ./���  � ��# �  P� 	 � {�
 .  . ���  �@J�Opacity$	 .56Q��� "  .���  � ��$ 1q���  � ��
 ���� ��  � ��
 �   ���  � ��$ .1q���  � ��
 �   ���  � �� �� "  .R��� #��z��#��z��#��z�� . ._��� $��Center=�$��Center=�$��5q� P� 	 �@J�IsKeyboardFocusWithin
 . . ���  � ��# �  ]�  ��  �@ 
IsSelected . ��  �@��IsSelectionActive .  ./���  � ��# �  ]�  ��  �@ 
IsSelected . ��  �@��IsSelectionActive . ./���  � ��# �  P� 	 � {�
 .  . ���  �@J�Opacity$ 1Q���  � ��
 �   ��� "  .���  � ��
 ���� ��  �@J�SnapsToDevicePixels . ��  �@=�ErrorTemplate Z� ��  �@ ValidationErrorTemplate �� .R��� ���#d50000$��2,0,0,0q�$��!��$��Center=���  � �� �� "  .R��� $ 
DGR_Border��#��z��#��z��#��z�� . ._�   �� $
��Auto ��� $��* � �� $��* ��� $
��Auto �.+�  $��1��#��z # z   $��1��$��1��#y�z  �� *AreRowDetailsFrozen+# Z # Z  �� "    $��2��$ Vertical=�y��� *HeadersVisibility+# Z # Z  �� "   P� 	 �@ 
IsSelected
 . . ���  � ��# �  P� 	 �@J�IsMouseOver
 . . ���  � ��# �  P� 	 �@ 	IsNewItem
 . . ���  � ��$ 0q�