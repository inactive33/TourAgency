   M S B A M L   `   `   `  ���� E  ATourAgency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TourAgency
TourAgency  $    TourAgency.HotelsSearchControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:TourAgency     $��10q�.��� .+���   �� Orientation$  
Horizontal=�$��Stretch=�$	��Top=�$��0��.+��� .+��� $��
Отель��$��Center=�$��0,0,10,0q��� -    ��Name$ ResortSearchBox��$	��120��$��0,0,10,0q��� .+��� $%��Звездность отеля��$��Center=�$��0,0,10,0q��� -   $ StarsSearchBox��$	��120��$��0,0,10,0q��� $��1��$	��Top=�$��10,0,0,0q�.+��� $ ��Дополнительно��$��Center=�$��0,0,10,0q��� -    ��Name$ CustomCheckBoxComboBox��$	��120��$��0,0,10,0q�.@��� .���� .+��� $��Бар���� $��
Буфет���� $��Бассейн���� $��
Сауна���� $
��WiFi���� $��Пляж���� -   $��
Поиск��$��Bottom=�$��75��$��30��$��10,0,0,0q�
�������
����  ��� -    ��Name$ ResultsBoard��
���   �$��1q�$��Stretch=�$��Stretch=�$��10,60,10,10q�._��� .���� -   $��LViewHotels��$��2��$��Disabled=����� .R��  � Orientation$ 
Horizontal=�$��Center=����� .R��� 
���   � �� CornerRadius$ 15�� �� Padding$ 5q�._��  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $	��100 ��� $��* �.+��� $��0��.+��� $��/Resources/default.png��$��Center=�$	��Top=�$��1��$	��100��$	��100��$��5q�$��0���� $��1��.+��� $  
Horizontal=�$��1��$��0��.+��� $
��Bold"�$
��Left=�$��16(����� *HashedID_hotel+�� $
��Bold"�$
��Left=�$��16(����� *Name+�� $��3��$  
Horizontal=�$��0,10,0,0q�.+��� ���#00bfff$��1q�$ 10��$ 5q�$	��0,5q�._��� .+��� $%��Звездность отеля��$��Center=��� $��Center=�$
��Bold"����� *	HotelStar+�� $��4��.+��� $��Тур включает��$
��Left=�$
��Bold"�$��14(��� $  
Horizontal=�$
��Left=�.+��� ���#E4CBF0$��1q�$
��Left=�$ 10��$ 5q�$	��0,5q�._��� .+��� $
��WiFi��$��Center=�$
��Bold"��� $��Center=�{�.  	 d� 	IsChecked	 �� *List_Present.Present_Wifi+�� ���#E4CBF0$��1q�$
��Left=�$ 10��$ 5q�$	��0,5q�._��� .+��� $��Пляж��$��Center=�$
��Bold"��� $��Center=�{�.  	 �� *List_Present.Present_Beach+�� ���#E4CBF0$��1q�$
��Left=�$ 10��$ 5q�$	��0,5q�._��� .+��� $��Бар��$��Center=�$
��Bold"��� $��Center=�{�.  	 �� *List_Present.Present_Bar+�� ���#E4CBF0$��1q�$
��Left=�$ 10��$ 5q�$	��0,5q�._��� .+��� $��Экскурсия��$��Center=�$
��Bold"��� $��Center=�{�.  	 �� *%#List_Include.Tour_Include_Excursion+�� ���#E4CBF0$��1q�$
��Left=�$ 10��$ 5q�$	��0,5q�._��� .+��� $��Развлечения��$��Center=�$
��Bold"��� $��Center=�{�.  	 �� *)'List_Include.Tour_Include_Entertaiments+�� $  
Horizontal=�$��1��$��5��.+��� 
 ��Name$
 BtnReserveTour��-   $ ��Забронировать��$	��200��$��30��$��5q�
����  �
�������y��� *TouristControlVisibility+�� $��BtnEdit��-   $ ��Редактировать��$	��200��$��30��$��5q�
����  �
�������y��� *AdminControlVisibility+�� $��	BtnDelete��-	   $��Удалить��$	��200��$��30��$��5q�
����  �
�������y��� *AdminControlVisibility+