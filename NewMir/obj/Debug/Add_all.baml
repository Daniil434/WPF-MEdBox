   M S B A M L   `   `   `  ????A  =NewMir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:NewMir.ViewModelNewMir.ViewModel  5   	   clr-namespace:NewMirNewMir  5   	       NewMir.Add_all   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -vmclr-namespace:NewMir.ViewModel     5   	   &localclr-namespace:NewMir     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962ac _MaterialDesignThemes.MahApps, Version=0.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	     ? Title$  Add_all??5
   	   $
??1000??6   $
??1200??6'    ? DataContext 5      $  NewMir.ViewModel.MainViewModel  5   
   6   .??5      ? ???#ffdada.+?5   
   ?? $??0??6   
??????? ?? CornerRadius$ 23??61    J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q?6#      Color$ Black??63      ShadowDepth$ 0Q?6A   6S   ._?5      ?? $??0,0,0,-3q?6   .+?5      ?  ? Orientation$ 
Horizontal=?6   $??Center=?65   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   
Foreground
 ?? ??.+?5      ?? $
??Left=?6   $<??6Добавить нового пользователя??68      MaterialDesignFlatButton#??[  5      $??20(?6O   $
??Auto??6]   $
??auto??5      $??2??6*   ??6;   ?? *OpenAdd_User+6_   ?? 5      $??Center=?6   $.??(Добавить нового врача??6:   #??[  5      $??20(?6O   $
??Auto??5      $
??auto??6+   ??69   ?? *OpenVrach_menu+6_   ?? 5       $??Center=?6   $M??GДобавить новое медицинское учреждение??6:   #??[  5!      $??20(?6O   $
??Auto??5"      $
??auto??6+   ??68   ?? *OpenAdd_Hospital+6a   ?? 5#      $??Center=?6   $.??(Добавить новую услугу??6:   #??[  5$      $??20(?6O   $
??Auto??5%      $
??auto??6+   6=   5&      5)      5*       ? 5,   
   -   5        	  ?Name$	 MyFrame_Admin??5,      $??	0 110 0 0q?6'   $
??1000??6:   $	??770??6G   
  ? NavigationUIVisibility$
 Hidden=?6T   ??6t   ?? *	CurPage+6?   5/      50      