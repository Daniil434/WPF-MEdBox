   M S B A M L   `   `   `  ????A  =NewMir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NewMirNewMir  5   	       NewMir.Doctors_menu   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:NewMir     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962ac _MaterialDesignThemes.MahApps, Version=0.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5
   	     N? Title$  Window1??5   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      $	??120 ?6   ?? 5      $??* ?6   ?? 5      $??80 ?6   .+?5   
   ?? $??0??6   
??????? ?? CornerRadius$ 23??61    J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q?6#      Color$ Black??63      ShadowDepth$ 0Q?6A   6S   ._?5      ?? $??0,0,0,-3q?6   .+?5      ?  ? Orientation$ 
Horizontal=?6   $??Center=?65   .+?5      ??  ?? Orientation$ 
Horizontal=?6!   .+?5      ?? $:??4Введите название для поиска:??6$   
???? ?? !  MaterialDesignButtonTextBlock#??[  5   $   	 ?? TextAlignment$
	 Left=?6[   $??24(?6p   $??40??6~   $	??355??5   $   62   ?? 5      -   5        $??
TBoxSearch??5   ?   $??5 0 5 0q?6"   $	??255??63     MaterialDesignTextBox#??[ 6Q   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Введите логин??5   G   $??20(?6v   6?   5       ?? 5!      $ 
Horizontal=?6!   .+?5"      ?? $??5 0 5 0q?6$   $"??Выберите врача:??65   
???? ??#??[  6d   $
	 Left=?6?   $??24(?6?   $??40??6?   $	??185??5#   $   62   ?? 5$      -   5        $??ComboType_cpechialnoct??5$   @   $??5 0 5 0q?6#   $	??225??64     MaterialDesignComboBox#??[ 6^    ?? DisplayMemberPath$ spechialnost??5%   #   5'      5)      ?? 5*      $??5 0 5 0q?6    $/??)Выберите график врача:??61   
???? ??#??[  6g   $
	 Left=?6?   $??24(?6?   $??40??6?   $	??300??5+   $   62   ?? 5,      -   5        $??ComboType_grahic_vrach??5,   <   $??5 0 5 0q?6   $	??255??60   #??[ 6Z   $ Grahic_vrach??5-   #   5/      ?? 50      $??5 0 5 0q?6    $.??(Выберите поликлинику:??61   
???? ??#??[  6f   $
	 Left=?6?   $??24(?6?   $??40??6?   $	??300??51   $   62   ?? 52      -   5        $??ComboType_hospital??52   <   $??5 0 5 0q?6   $	??255??60   #??[ 6V   $ name_hospital??53   #   55      ?? 56      -   5        $
??Left=?56      $??Добавить??68     MaterialDesignFlatButton#??[ 57      $??20(?6O   $
??Auto??6]   $	??140??58      $??2??6)   6S   ?? 59      -   5        $??5 0 5 0q?59      $??Center=?6.   $
??word??6K   #??[ 5:      $??20(?6O   $
??Auto??5;      $??80??6+   6R   ?? 5<      -   5        $??5 0 5 0q?5<      $??Center=?6.   $??email??6K   #??[ 5=      $??20(?6O   $
??Auto??5>      $??80??6+   6R   5A      5D      5E      ?? 5G   
   $??1??6   $
??1160??6   
???????$ 10??6>    5H        5I      $ 15Q?6#   $ Black??63   $ 0Q?6A   6S   ._?5K      ?? -   5         ??Name$ List_of_vrach??5K      $	??730??6/   $
??1100??6<   $??
0 10 20 10q?6I   $??Disabled=?5L      $??Center=?6M   ??5M      ?? 5N      .R?5O      ? $??Center=?6$   $ 
Horizontal=?6A   6\   5P      ??5R      ?? 5S      .R?5T      ? $??	10 0 10 0q?6   $	??430??62    5U      ?? 5V   "   $??80 ?60   6>   ?? 5W   "   $	??300 ?60   6?   ?? 5X   "   $
??auto ?60   6@   ?? 5Y   "   $
??auto ?60   6@   ?? 5Z   "   $
??auto ?60   6@   .+?5\      ?? $??Image_User_List??6$   $	??400??6;   $??1??6G   $??UniformToFill=?6T   $??Center=?5]   $   $??5q?6A   ??5^   "   ?? 5_   &    ?? Path$	 img?6.    ?? TargetNullValue 5`   *   ??5a   .   FBC:\\Users\\User\\Desktop\\PRG\\NewMir\\NewMir\\User_Photo\\gaf.jpg??5c   /   5e   '   5g      ?? 5h       ??Name$ textBox_write_login??5j   (   $??Center=?5h   &    ?? TextAlignment$ Center=?6C   
???   ?.  (MaterialDesignThemes.Wpf.TextBlockAssist   AutoToolTip .  % !MaterialDesignFloatingHintTextBox#??[ 5i   (   $??5 5 5 15q?6c   $??20(?5k   (   $??0??66   
 5j   E   ?? *fio+5k   6   ?? 5l      $ 	write_fio??5n   @   $??2??5l   &   $??5 5 5 15q?63   $
??Left=?6E   #??[ 6`   
???? ??$??20(?5n   S   
 5m   &   ?? *name+ ?? StringFormat$ ФИО: {0}??5n   S   ?? 5p      $ 
write_name??5q   (   $??2??5p   &   $??5 5 5 15q?63   $??Center=?6E   
???? ??#??[ 5r   &   $??20(?6a   
 5q   <   ?? *	otchestvo+5r   a   ?? 5t      $ write_otchestvo??5v   (   $??2??5t   &   $??5 5 5 15q?63   $??Right=?6E   
???? ??#??[ 5u   &   $??20(?5v   A   
 5u   a   ?? *spechialnost+5v   A   ?? 5w      $ write_email??5x   C   $??3??5w   &   $??5 5 5 15q?63   $
??Left=?5x   (   
???? ??#??[ 5y   &   $??20(?5z   )   
 5y   a   ?? *name_hospital+5z   )   ?? 5{      $ 
write_data??6O   $??3??6&   $??Right=?63   
???? ??$??5 5 5 15q?6{   #??[ 5|   &   $??20(?5}   '   
 5|   a   ?? *number_kabinet+5}   '   ?? 5~      $
??Left=?6(   $??4??6C   $+??%График работы врача:??6P   $??
5 25 5 270q?6l   
???? ??  MaterialDesignTextBlock#??[ 5   &   $??20(?5?   )   ?? 5?      $ write_password??5?   (   $
??Left=?5?   &   $??4??6A   $??
85 5 5 270q?6N   
???? ??#??[ 5?   &   $??20(?5?   @   
 5?   a   ?? *Grahic_vrach+$ Пароль: {0}??5?   @   ?? 5?       ??Name$ Button1??6%   $??4??66   $??Center=?6C   $??	5,5,5,250q?6a   $??Изменить??5?   %   #??[ 68   6n   ?? 5?      -	   5        $??4??5?   %   $??	5,5,5 250q?62   $??Right=?6E   $??Удалить??6a   #??[ 5?   %   6p   5?      5?      5?      5?      ?? 5?   
   $??2??6   
???????$ 23??61    5?        5?      $ 15Q?6#   $ Black??63   $ 0Q?6A   6S   ._?5?      ? .+?5?      ?? $??Right=?6   $??About??65   #??[ 6E   $	??216??6x   $??20(?6?   ?? 5?      $
??Left=?6   $
??Help??64   #??[ 6C   $	??216??6v   $??20(?6?   5?      5?      5?      5?      