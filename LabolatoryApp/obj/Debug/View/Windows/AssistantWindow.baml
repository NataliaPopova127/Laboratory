   M S B A M L   `   `   `  ????H  DLabolatoryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:LabolatoryApp.View.WindowsLabolatoryApp.View.Windows  5   	   0    *LabolatoryApp.View.Windows.AssistantWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:LabolatoryApp.View.Windows     5   	     ? Icon$  /Assets/logo.ico??5   	    ? WindowStartupLocation$ CenterScreen=?5	   	    ? Title$ Лаборант??5
   	   $	??450??6   $	??800??6'   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      $??60 ?6   ?? 5      .+?5   
   ?? $??2??6   ._?5      ??  ?? Orientation$ 
Horizontal=?6   $??Right=?62   .+?5      ?? $??/Assets/laborant_1.jpeg??6   ?? 5      $??	20 0 50 0q?6   .+?5      ?? -   5         ??Name$ tbName??5       $??Имя??60   ?? 5      -   5        $ tbRole??5       $??Лаборант??60   5      5      5      ?? 5   
   -   5        $ tbTimer??5      $??00:00??6%   $??Center=?62   $??2??6O   $??Center=?6c   ?? 5   
   -   5         ??Name$ 
btnSignOut??5      $??
Выйти??6%      accentColor#??[  65   $	??100??5       $??30??6   $??	10 10 0 0q?6)   $
??Left=?6<   $	??Top=?5!      6)   ?? 5#   
   $??1??6   $	??2.5??6   $??Right=?6*   ?? 5%   
   $??1??6   $??
10 50 10 0q?6"   .+?5&      ?? -   5        $ btnMakeReport??5&      $)??#Сформировать отчет??6,   $??0 0 0 10q?6I   5'      ?? 5(      -   5        $ btnTakeBiomaterial??5(      $-??'Принять биоматериалы??61   6P   5)       ? 5+   
   -   5          ?Name$ 	mainFrame??5+   -   $??1??6   $??1??6   	  ? NavigationUIVisibility$	 Hidden=?6@   5,      5-      