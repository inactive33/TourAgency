   M S B A M L   `   `   `  ���� E  ATourAgency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TourAgency
TourAgency  "    TourAgency.TourSearchControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:TourAgency     
�������$��10q�.��� .+���   �� Orientation$  
Horizontal=�$��Stretch=�$	��Top=�$��0��.+��� .+��� $��Курорт��$��Center=�$��0,0,10,0q��� -    ��Name$ ResortSearchBox�� �� SelectedItem$
 Name�� �� SelectedValuePath$ 	ID_Resort�� �� DisplayMemberPath$
 Name��$	��120��$��0,0,10,0q����� *	Resorts+ �� SelectedValue �� *	ID_Resort+ �� Mode$ TwoWay=��� .+��� $��Страна��$��Center=�$��0,0,10,0q��� -   $ CountrySearchBox��$
 Name��$
 Name��$	��120��$��0,0,10,0q��� .+��� $��Дата вылета��$��Center=�$��0,0,10,0q�(  "System.Windows.Controls.DatePicker  -     Name$ DepartureDateSearchBox��$	��120��$��0,0,10,0q��� $��1��$	��Top=�$��10,0,0,0q�.+��� $ ��Дополнительно��$��Center=�$��0,0,10,0q��� -   $ CustomCheckBoxComboBox��$	��120��$��0,0,10,0q�.@��� .���� .+��� $��
Полёт���� $
��Visa���� $��
Отель���� $��Экскурсия���� $��Развлечения���� -   $��
Поиск��$��Bottom=�$��75��$��30��$��10,0,0,0q�
�������
����  ��� -    ��Name$ ResultsBoard��
���   �$��1q�$��Stretch=�$��Stretch=�$��10,60,10,10q�._��� .���� -   $��
LViewTours��$��2��$��Disabled=����� .R�� 	 � Orientation$	 
Horizontal=�$��Center=����� .R��� 
���   �
 �� CornerRadius$
 15�� �� Padding$ 5q�._��  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $	��100 ��� $��* �.+��� $��0��.+��� $��/Resources/default.png��$��Center=�$	��Top=�$��1��$	��100��$	��100��$��5q�$��0���� $��1��.+��� $  
Horizontal=�$��1��$��0��.+��� $
��Bold"�$
��Left=�$��16(����� *
HashedID+�� $��1��.+��� $��60��$
��Left=�$	��800��$
��Wrap=�$��14(�$��0,5,0,0q����� *Tour_description+�� $��3��$  
Horizontal=�$��0,10,0,0q�.+��� ���#00bfff$��1q�$
 10��$ 5q�$	��0,5q�._��� .+��� $��Цена��$��Center=��� $��Center=�$
��Bold"����� *
PriceRub+�� ���#00bfff$��1q�$
 10��$ 5q�$	��0,5q�._��� .+��� $��Тип тура��$��Center=��� $��Center=�$
��Bold"����� *	Tour_type+�� ���#00bfff$��1q�$
 10��$ 5q�$	��0,5q�._��� .+��� $��Страна��$��Center=��� $��Center=�$
��Bold"����� *Country.Name+�� ���#00bfff$��1q�$
 10��$ 5q�$	��0,5q�._��� .+��� $��Номер рейса��$��Center=��� $��Center=�$
��Bold"����� *Flight.Flight_number+�� ���#00bfff$��1q�$
 10��$ 5q�$	��0,5q�._��� .+��� $��Комиссия��$��Center=��� $��Center=�$
��Bold"����� *	Comission+�� ���#00bfff$��1q�$
 10��$ 5q�$	��0,5q�._��� .+��� $��Туроператор��$��Center=��� $��Center=�$
��Bold"����� *Company.Name+�� ���#00bfff$��1q�$
 10��$ 5q�$	��0,5q�._��� .+��� $��Курорт��$��Center=��� $��Center=�$
��Bold"����� *Resort.Name+�� ���#00bfff$��1q�$
 10��$ 5q�$	��0,5q�._��� .+��� $��Длительность��$��Center=��� $
��Bold"�$��Center=����� *FormattedDuration+�� ���#00bfff$��1q�$
 10��$ 5q�$	��0,5q�._��� .+��� $��
Отель��$��Center=��� $��Center=�$
��Bold"����� *
Hotel.Name+�� $��4��.+��� $��Тур включает��$
��Left=�$
��Bold"�$��14(��� $  
Horizontal=�$
��Left=�.+��� ���#E4CBF0$��1q�$
��Left=�$
 10��$ 5q�$	��0,5q�._��� .+��� $��
Полёт��$��Center=�$
��Bold"��� $��Center=�{�.   d� 	IsChecked �� *" List_Include.Tour_Include_Flight+�� ���#E4CBF0$��1q�$
��Left=�$
 10��$ 5q�$	��0,5q�._��� .+��� $
��VISA��$��Center=�$
��Bold"��� $��Center=�{�.   �� * List_Include.Tour_Include_Visa+�� ���#E4CBF0$��1q�$
��Left=�$
 10��$ 5q�$	��0,5q�._��� .+��� $��
Отель��$��Center=�$
��Bold"��� $��Center=�{�.   �� *!List_Include.Tour_Include_Hotel+�� ���#E4CBF0$��1q�$
��Left=�$
 10��$ 5q�$	��0,5q�._��� .+��� $��Экскурсия��$��Center=�$
��Bold"��� $��Center=�{�.   �� *%#List_Include.Tour_Include_Excursion+�� ���#E4CBF0$��1q�$
��Left=�$
 10��$ 5q�$	��0,5q�._��� .+��� $��Развлечения��$��Center=�$
��Bold"��� $��Center=�{�.   �� *)'List_Include.Tour_Include_Entertaiments+�� $  
Horizontal=�$��1��$��5��.+���  ��Name$ BtnReserveTour��-   $ ��Забронировать��$	��200��$��30��$��5q�
����  �
�������y��� *TouristControlVisibility+�� $��BtnEdit��-	   $ ��Редактировать��$	��200��$��30��$��5q�
����  �
�������y��� *AdminControlVisibility+�� $��	BtnDelete��-
   $��Удалить��$	��200��$��30��$��5q�
����  �
�������y��� *AdminControlVisibility+