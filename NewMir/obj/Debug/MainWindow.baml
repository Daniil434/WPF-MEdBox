   M S B A M L   `   `   `  ????A  =NewMir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NewMirNewMir  5   	       NewMir.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:NewMir     5   	   _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962ac _MaterialDesignThemes.MahApps, Version=0.2.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	     ? Title$  
MainWindow??5	   	   $	??600??6   $	??800??6)    ? WindowStyle$ ThreeDBorderWindow=?65    ? Icon$ bJSKdoptSS0.png??6V    ? ShowInTaskbar .  .??5
      ? ???#ffdada.+?5   
   ??  ? ContextMenu 5      ?? 5      .@?5      m?  m? Command$	 Cut??6   5      m? 5      $
 Copy??6   5      5      5      ?? 5   
   $	??400??6   $	??300??6    $	??500??60   $??20,35,20,35q?6@   
???????$??Center=?6h   $	??600??6?    ?? Padding$ 30q?6?    ?? CornerRadius$ 23??6?   $	??410??6?    J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 10Q?6#   
   Color$
 Black??63      ShadowDepth$ 0Q?6A   6S   ._?5      ?? $??0,0,0,-3q?6   .+?5      ?? $	??Mir??6   $??36(?6'   $
??Bold"?65   $??Bookman Old Style)?6G    ?? TextAlignment$ Center=?6f   $??0 0 0 20q?6}   ?? 5      -   5         ??Name$ textBox_Avt_login??5      $??0 0 0 20q?65   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Введите логин??6G    %  !MaterialDesignFloatingHintTextBox#??[  6v   $??20(?6?   G? 5      -   5         G?Name$ passBox_Avt_password??5      $??0,0,0,20q?6<   $! Введите пароль??6N    ) %MaterialDesignFloatingHintPasswordBox#??[ 6~   $??24(?6?   ? 5       $??0 0 0 20q?6   .+?5!      ?? -   5        $
??Left=?5!      $??Регистрация??68   $
??Auto??6O   $??
10 20 0 10q?6]   $	??150??6q   $??20(?6}   6?   ?? 5"      -   5        $??Right=?5"      $&?? Авторизироваться??69   $??	0 20 0 10q?6T   $	??216??6g   $??20(?6s   $
??Auto??6?   6?   5#      ? 5$      $??0 0 0 20q?6   .+?5%      ?? $??Center=?6   $ ??Забыли пароль???6:     MaterialDesignFlatButton#??[ 6S   $	??216??6?   $??20(?6?   $
??Auto??6?   ?? 5&      $??Right=?6   $??About??69   #??[ 6I   $	??216??6|   $??20(?6?   $
??Auto??6?   ?? 5'      $
??Left=?6   $
??Help??68   #??[ 6G   $	??216??6z   $??20(?6?   $
??Auto??6?   5(      5*      5+      5,      5-      