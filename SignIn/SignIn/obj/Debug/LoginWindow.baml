   M S B A M L   `   `   `  ????A  =SignIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SignInSignIn  5   	       SignIn.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:SignIn     5   	   -   5          ? Title$  LoginWindow??5   	   $	??450??6   $	??800??6*      
baseWindow#??[  66    ? WindowStartupLocation$ CenterScreen=?6Z    ? 
ResizeMode$ NoResize=?6?   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      6!    ? RowDefinitions 5   
   ?? 5      $??75 ?6   ?? 5      $??40 ?6   ?? 5      $??40 ?6   ?? 5      .+?5   
   ? ???#FFE76$   ?? 5   
   $??/Resources/Romashki.png??6   $??10q?61   $
??Left=?6=   ?? 5   
   $??0??6   $??Авторизация??6!   $??Center=?64   $??Center=?6O   $??20(?6l   ?? 5   
   $??1??6    ?? Orientation$ 
Horizontal=?6"   .+?5      ?? $??
Логин??6   $
??20,0q?6%   $??Center=?63   $	??100??6N   6\   ?? 5      -   5         ??Name$ TbLogin??5      $??1??6'   $	??200??67   $??30??6C   5      ?? 5   
   $??2??6   $ 
Horizontal=?6"   .+?5      ?? $??Пароль??6   $
??20,0q?6&   $??Center=?64   $	??100??6O   $??0??6[   6m   G? 5      -   5         G?Name$ TbPass??5      $??30??6*   $	??200??66   5      ?? 5   
   $ 
Horizontal=?6   $??3??6.   $??Center=?6;   .+?5      ?? -   5        $??BtnOk??5   -   $	??100??6   $??30??6!   $??OK??6:   
????? ?$	??5,0q?6m   6|   ?? 5       -   5         ??Name$ 	BtnCansel??5    -   $	??100??6   $??30??6!   $??Cancel??6@   
????? ?$	??5,0q?6{   6?   5!      5"      5#      