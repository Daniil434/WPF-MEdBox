   M S B A M L   `   `   `  ????U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	   A =NewMir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:NewMir.User_ControlsNewMir.User_Controls 5   	   clr-namespace:NewMirNewMir 5	   	      NewMir.User_Menu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Y UFontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5   	   +uc"clr-namespace:NewMir.User_Controls  5   	    localclr-namespace:NewMir  5	   	   $	??740??5   	   $
??1280??6     ? WindowStartupLocation$  CenterScreen=?6#    ? WindowStyle$
 None=?5   	    ? AllowsTransparency . 
?????? .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??250 ?6   ?? 5      $??* ?6   .+?5   
   ??  ?? CornerRadius$ 	10 0 0 10??6   ??5      ?? 5       ?? 
StartPoint$ 0.5,0&?6&    ?? EndPoint$ 0.5,1&?69   .??5      ?  ? Color$ #223266??6#    ? Offset$ 0Q?63   ? 5      $ 	#FF1F1E44??6#   $ 1Q?65   5      ._?5      ?? -   5        	 ??Name$	 	panelMenu??5      .+?5      ?? -   5        $	 	panelLogo??5      
 ?? Orientation$
 
Horizontal=?60   $??Center=?6I   $	??100??6f   $	??246??6s   .+?5      ?? -   5         ??Name$ btnHome??5      $??YscRtMrdIx0.jpg??6-   5!      5"      ?? 5$      $	??0.8??6   ???#46558a$??20 30 20 30q?6>   ?? 5'      -   5         ??Name$ 	Dashboard??5'         menuButtonActive#??[  6G   ??6q   Z? .??5(      ?? $
 
Horizontal=?6!   .+?5)      !  FontAwesome.Sharp.IconImage  -   5          Name$ Icon_Image1??5)   '   ?  ?FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=5.15.4.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=?6<     menuButtonIcon#??[ 6H      
Foreground
 ?????6p   ?? 5*      -   5         ??Name$ Text_Block_User1??5*   $   $??	Dashboard??6>     menuButtonText#??[ 6O   
???????6w   5+      5,      ?? 5.      -   5          
menuButton#??[ 5.   0   
?????????6T   Z? .??5/      ?? $
 
Horizontal=?6!   .+?50        -   5        $ Icon_Image2??50   '   $ FileSignature=?6<   #??[ 6Q   
 ?????6y   ?? 51      -	   5        $ Text_Block_User2??51   $   $??Listing??6>   #??[ 6M   
???????6u   52      53      ?? 55      -
   5        #??[ 55   3   ??6W   Z? .??56      ?? $
 
Horizontal=?6!   .+?57        -   5        $ Icon_Image3??57   '   $ EnvelopeOpenText=?6<   #??[ 6T   
 ?????6|   ?? 58      -   5        $ Text_Block_User3??58   $   $??Messages??6>   #??[ 6N   
???????6v   59      5:      ?? 5<      -   5        #??[ 5<   3   ??6W   Z? .??5=      ?? $
 
Horizontal=?6!   .+?5>        -   5        $ Icon_Image4??5>   '   $ ShoppingCart=?6<   #??[ 6P   
 ?????6x   ?? 5?      -   5        $ Text_Block_User4??5?   $   $??Orders??6>   #??[ 6L   
???????6t   5@      5A      ?? 5C      -   5        .??5D      ?? $
 
Horizontal=?6!   .+?5E        -   5        $ Icon_Image5??5E   '   $ 	ChartArea=?6<   
 ?????6N   ?? 5F      -   5        $ Text_Block_User5??5F   $   $??
Statistics??6>   
???????6Q   5G      5H      ?? 5J      -   5        #??[ 5J   2   .??5K      ?? $
 
Horizontal=?6!   .+?5L        -   5        $ Icon_Image6??5L   '   $ Coins=?6<   #??[ 6I   
 ?????6q   ?? 5M      -   5        $ Text_Block_User6??5M   $   $??Revenue??6>   #??[ 6M   
???????6u   5N      5O      ?? 5Q      #??[ 6   .??5R      ?? $
 
Horizontal=?6!   .+?5S        $ FlagCheckered=?6'   #??[ 6<   ?? 5T      $??Promote??6$   #??[ 63   5U      5V      ?? 5X      #??[ 6   .??5Y      ?? $
 
Horizontal=?6!   .+?5Z        $	 Cog=?6'   #??[ 62   ?? 5[      $??Settings??6$   #??[ 64   5\      5]      ?? 5_      #??[ 6   .??5`      ?? $
 
Horizontal=?6!   .+?5a        $ PowerOff=?6'   #??[ 67   ?? 5b      $??Logout??6$   #??[ 62   5c      5d      5f      5g      ?? 5h   
   $??1??6   $
??Left=?6&   $	??131??6A   $	??Top=?6N   $
??1030??6f   ??5i      ?? 5j      $ 0.5,0&?6&   $ 0.5,1&?69   .??5k      ? $ #223266??6#   $ 0Q?63   ? 5l      $ 	#FF1F1E44??6#   $ 1Q?65   5m      5o      5q      5r      