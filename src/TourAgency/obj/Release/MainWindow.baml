   M S B A M L   `   `   `  ���� E  ATourAgency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TourAgency
TourAgency  ;"clr-namespace:TourAgency.ViewModelTourAgency.ViewModel      TourAgency.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     V RPrism.Wpf, Version=9.0.537.60525, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  $localclr-namespace:TourAgency  2	viewmodel"clr-namespace:TourAgency.ViewModel    � Title$3  -Туристическое агентство��$	��450��$	��800�� � WindowState$ 	Maximized=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ CanResizeWithGrip=�.���  � RowDefinitions �� $��75 ��� $��* ��� $��75 � � ColumnDefinitions �� $	��125 ��� $��* �.+��� $��1��$G��AТуристическое агенство - Земная ось��$��30(�$��Center=�$��Center=�� $��1�����#d4d7ff K� ZIndex$ -2��� $��2��$��1�����#d4d7ff � -   $��	MainFrame��$��1��  � NavigationUIVisibility$ Hidden=�$��1��� $��0�����#d4d7ff$ -2��� $��0��$��2�����#d4d7ff$ -2���� $��0��$��1�����#F2F5F9���#DCE0E6$��1q�._��� .+��� $��Навигация��$��18(�$
��Bold"����#333333$��10,10,10,20q��� -   $��BtnTours��$
��10,5q�$��10q� � Cursor$
 Hand�����#E7EFF6���#A9C9E9���� $$��Туры с перелётом��$
��Wrap=�	 �� TextAlignment$	 Center=�$��14(����#2C3E50�� -   $��BtnNavHotels��$��
Отели��$
��10,5q�$��10q�$��14(����#E7EFF6���#2C3E50���#A9C9E9$
 Hand��$��Stretch=��� -   $��
BtnNavTour��$
��10,5q�$��10q�$
 Hand�����#E7EFF6���#A9C9E9���� $#��Кабинет туриста��$
��Wrap=�$	 Center=�$��14(����#2C3E50