   M S B A M L   `   `   `  ????U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	   A =NewMir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:NewMir.User_ControlsNewMir.User_Controls 5   	   3clr-namespace:NewMir.ViewModelNewMir.ViewModel 5	   	   clr-namespace:NewMirNewMir 5
   	      NewMir.Admin_menu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5   	   +uc"clr-namespace:NewMir.User_Controls  5   	   'vmclr-namespace:NewMir.ViewModel  5	   	    localclr-namespace:NewMir  5
   	   $	??740??5   
   $
??1280??6     ? WindowStartupLocation$  CenterScreen=?6$    ? WindowStyle$
 None=?5   	    ? AllowsTransparency . 
??????  ? DataContext 5      $ NewMir.ViewModel.MainViewModel  5   
   6   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??250 ?6   ?? 5      $??* ?6   .+?5   
   ??  ?? CornerRadius$ 	10 0 0 10??6   ??5      ?? 5       ?? 
StartPoint$ 0.5,0&?6&    ?? EndPoint$ 0.5,1&?69   .??5      ?  ? Color$ #223266??6#   	 ? Offset$	 0Q?63   ? 5      $ #27376B??6#   $	 1Q?63   5      ._?5       ?? .+?5"      ?? 
 ?? Orientation$
 
Horizontal=?6   $??Center=?66   $??0 35 0 0q?6S   .+?5#      ?? $ 10??6   $??40??6/   $??40??6:   ??5$      ?? 5%      $	 0,0&?62   $	 1,2&?6C   .??5&   "   ? $ #7F7CF1??6/   $	 0Q?6?   ? 5'   "   $ #D3B7FF??6/   $	 1Q?6?   5(      ._?5+      ?? $??JP??6$   ???#ffffff$??22(?6C   $??SemiBold"?6Q    ?? TextAlignment$ Center=?6g   $??Center=?6~   $??3 0 0 2q?6?   5,      ?? 5.      $??10 0 0 0q?6!   $??Center=?63   .+?5/      ?? $??Jonathan Perman??6$   $??15(?6;   $??0 0 0 5q?6I   ???#C2CFFF6Z   ?? 50      $??Beta 1.3??6$   ???#7788bf$??11(?6I   51      52      ?? 54      $	??0.8??6   ???#46558a$??20 30 20 30q?6>   ?? 57      -   5         ??Name$ Button_Admin??57         menuButtonActive#??[  6/   ??6n   ?? *OpenDashBoard_menu+.??58      ?? $
 
Horizontal=?6!   .+?59      !  FontAwesome.Sharp.IconImage  ?  ?FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=?6'     menuButtonIcon#??[ 63   ?? 5:      $??	Dashboard??6$     menuButtonText#??[ 65   5;      5<      ?? 5>      -   5          
menuButton#??[ 5>      ??6=   ?? *OpenList_Users+.??5?      ?? $
 
Horizontal=?6!   .+?5@        $ FileSignature=?6'   #??[ 6<   ?? 5A      $??Listing Users??6$   #??[ 69   5B      5C      ?? 5E      -   5        #??[ 5E      ??6=   ?? *OpenMessages+.??5F      ?? $
 
Horizontal=?6!   .+?5G        $ EnvelopeOpenText=?6'   #??[ 6?   ?? 5H      $??Messages??6$   #??[ 64   5I      5J      ?? 5L      -   5        #??[ 5L      ??6=   ?? *OpenDoctors_menu+.??5M      ?? $
 
Horizontal=?6!   .+?5N        $ FileSignature=?6'   #??[ 6<   ?? 5O      $??Personal??6$   #??[ 64   5P      5Q      ?? 5R      #??[ 6   ??6=   ?? *OpenHospital_Menu+.??5S      ?? $
 
Horizontal=?6!   .+?5T        $ FileSignature=?6'   #??[ 6<   ?? 5U      $??Hospital??6$   #??[ 64   5V      5W      ?? 5Y      -   5        #??[ 5Y      ??6=   ?? *OpenGrahic_admin+.??5Z      ?? $
 
Horizontal=?6!   .+?5[        $ 	ChartArea=?6'   #??[ 68   ?? 5\      $??
Statistics??6$   #??[ 66   5]      5^      ?? 5`      -   5        #??[ 5`      .??5a      ?? $
 
Horizontal=?6!   .+?5b        $ Coins=?6'   #??[ 64   ?? 5c      $??Revenue??6$   #??[ 63   5d      5e      ?? 5g      -   5        #??[ 5g      ??6=   ?? *OpenList_Savki+.??5h      ?? $
 
Horizontal=?6!   .+?5i        $ FlagCheckered=?6'   #??[ 6<   ?? 5j      $??Заявки??6$   #??[ 62   5k      5l      ?? 5n      #??[ 6   .??5o      ?? $
 
Horizontal=?6!   .+?5p        $	 Cog=?6'   #??[ 62   ?? 5q      $??Settings??6$   #??[ 64   5r      5s      ?? 5u      #??[ 6   .??5v      ?? $
 
Horizontal=?6!   .+?5w        $ PowerOff=?6'   #??[ 67   ?? 5x      $??Logout??6$   #??[ 62   5y      5z      5|      5}       ? 5?   
   -   5          ?Name$ MyFrame_Admin??5?      $??1??6'     ? NavigationUIVisibility$ Hidden=?67   ??6W   ?? *	CurPage+6u   5?      5?      