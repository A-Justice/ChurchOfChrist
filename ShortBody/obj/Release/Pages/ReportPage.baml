   M S B A M L   `   `   `  ���� D  @ShortBody, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShortBody.PagesShortBody.Pages  E'clr-namespace:ShortBody.ValueConvertersShortBody.ValueConverters       ShortBody.Pages.ReportPage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:ShortBody.Pages     6cv'clr-namespace:ShortBody.ValueConverters       N� Title$  
ReportPage��.���� $
��Auto=�.���  � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto �.+���  	  white#��[  
���   �$��1q�$��20q�$	��260��._��  �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions .+��� $��0,0,0,5q�����  �� 
StartPoint$
 .5,0&� �� EndPoint$
 .5,1&�.���  � Color$ Black�� � Offset$ .7Q�� $ Transparent��$ 1Q�._���   head#��[  �� TextAlignment$ Center=�$��Zone Report������ � $��Center=�$��1��.+��� $��5q�.+���   
tbGradient#��[ $ Center=�$
��Zone���� $	��100�� �� SelectedItem �� *Zone+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 TwoWay=����� *Zones+���� .R��� ���� *
ZoneName+�� $��5q�.+��� #��[ $ Center=�$
��Type��$	��100���� -   $��cboType�� �� Text �� *Type+$	 PropertyChanged=�$
 TwoWay=�@��� $��Yearly���� $��Monthly���� $��Halfly���� $��	Quarterly���� $��TillDate��� $��2��$��Center=�.+��� -   $��stpYear��$��5q�.+��� #��[ $ Center=�$
��Year���� -   $��cboYear��$	��100������ *Years+ �� *Year+$
 TwoWay=��� -   $��stpHalf��$��5q�.+��� #��[ $ Center=�$
��Half���� -   $��cboHalf��$	��100�� �� *Half+$
 TwoWay=�@��� $	��1st���� $	��2nd���� -   $��
stpQuarter��$��5q�.+��� #��[ $ Center=�$��Quarter���� $	��100�� �� *	Quarter+$
 TwoWay=�@��� $	��1st���� $	��2nd���� $	��3rd���� $	��4th���� -   $��stpMonth��$��5q�.+��� #��[ $ Center=�$��Month���� $	��100�� �� SelectedIndex �� *Month+$
 TwoWay=�@��� $��January���� $��February���� $��March���� $��April���� $	��May���� $
��June���� $
��July���� $��August���� $��	September���� $��October���� $��November���� $��December��� $��Center=�$��3��.+��� -   $��btnGenerateZoneReport��$��10q�$��Generate������ *GenerateReportCommand+ J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 2Q��� $��1��#��[  
���   �$��1q�$��20q�$	��260��._��  �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto � .+��� $��0,0,0,5q����� $
 .5,0&�$
 .5,1&�.��� $ Black��$ .7Q�� $ Transparent��$ 1Q�._��� #��[ $ Center=�$��Monthly PrintOut������ � $��Center=�$��1��.+��� $��5q�.+��� #��[ $ Center=�$
��Area���� $	��100�� �� *	PrintArea+$	 PropertyChanged=�$
 TwoWay=����� *Areas+���� .R��� ���� *
AreaName+�� $��5q�.+��� #��[ $ Center=�$
��Year���� $	��100������ *Years+ �� *	PrintYear+$
 TwoWay=��� $��5q�.+��� #��[ $ Center=�$��Month���� $	��100�� �� *
PrintMonth+$
 TwoWay=�@��� $��January���� $��February���� $��March���� $��April���� $	��May���� $
��June���� $
��July���� $��August���� $��	September���� $��October���� $��November���� $��December��� $��Center=�$��3��.+��� -	   $��btnGeneratePrintOut��$��10q�$��Generate������ *GeneratePrintOutCommand+   $ 2Q��� $��2��#��[  
���   �$��1q�$��20q�$	��260��._��  �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto � .+��� $��0,0,0,5q����� $
 .5,0&�$
 .5,1&�.��� $ Black��$ .7Q�� $ Transparent��$ 1Q�._��� #��[ $ Center=�$��Analyis Report������ � $��Center=�$��1��.+��� $��5q�.+��� #��[ $ Center=�$
��Type��$	��100���� -
   $��cboAnalysisType�� �� *AnalysisType+$	 PropertyChanged=�$
 TwoWay=�@��� $��Yearly���� $��Monthly���� $��TillDate���� $��5q�.+��� #��[ $ Center=�$
��Kind��$	��100���� -   $��cboAnalysisKind�� �� *AnalysisKind+$	 PropertyChanged=�$
 TwoWay=�@��� $
��Zone���� $
��Area���� $��Group���� -   $��stpAnalysisYear��$y�	Collapsed=�$��5q�.+��� #��[ $ Center=�$
��Year���� $	��100������ *Years+ �� *AnalysisYear+$
 TwoWay=��� -   $��stpAnalysisMonth��$y�	Collapsed=�$��5q�.+��� #��[ $ Center=�$��Month���� $	��100�� �� *AnalysisMonth+$
 TwoWay=�@��� $��January���� $��February���� $��March���� $��April���� $	��May���� $
��June���� $
��July���� $��August���� $��	September���� $��October���� $��November���� $��December��� $��Center=�$��3��.+��� -   $��btnGenerateAnalysis��$��10q�$��Analyze��   $ 2Q�