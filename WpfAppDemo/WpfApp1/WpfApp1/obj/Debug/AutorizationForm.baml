   M S B A M L   `   `   `  ????J  FEasyCaptcha.Wpf, Version=0.9.0.1, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:EasyCaptcha.Wpf;assembly=EasyCaptcha.WpfEasyCaptcha.Wpf  5   	   B >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1 5   	      WpfApp1.MainWindow   5   	   ?easy6clr-namespace:EasyCaptcha.Wpf;assembly=EasyCaptcha.Wpf  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   $??Comic Sans MS)?5	   	     ? Title$  Авторизация??5
   	   $	??450??6   $	??800??6*   .??5      ? .+?5   
   G? -   5        $??PasswordHidden??5      ???#66CC66 G? PasswordChar$	 •??6A   $??19??6R   $	??190??6^   $??296,193,296,199q?6j   ?? 5   
   -   5        $??PasswordUnmask??5      $y?Hidden=?6(   ???#66CC66$??19??6Q   $	??190??6]   $??296,193,296,199q?6i   ?? 5   
   -   5        $??CB??5      $'??!Отобразить пароль??6   $
??Left=?69   $??525,197,0,0q?6T   $	??Top=?6i   6?   ?? 5   
   -   5        $??EnterButton??5      $??
Войти??6$   $
??Left=?64   $??358,253,0,0q?6O   $	??Top=?6d   $??75??6|   ???#498C516?   ?? 5   
   -   5        $??LoginTextBox??5      $
??Left=?6&   $??20??6A   $??296,137,0,0q?6M   ???#66CC66 ?? TextWrapping$
 Wrap=?6w   $	??Top=?6?   $	??190??6?   ?? 5   
   $
??Left=?6   $	??100??6+   $??
347,37,0,0q?68   $	??Top=?6L   $	??100??6d   $??Sources/logo.png??6p      EasyCaptcha.Wpf.Captcha  5   
   -   5          Name$ 	MyCaptcha??5      $	??200??6*   $??50??66   $??296,236,296,133q?6B   $y?Hidden=?6[   ?? 5   
   -   5         ??Name$ CaptchaTextBox??5      $
??Left=?6*   $??20??6E   $??296,300,0,0q?6Q   $
 Wrap=?6f   $y?Hidden=?6z   $	??Top=?6?   $	??200??6?   ?? 5   
   -   5        $??ButtonAnotherCaptcha??5      $??Другая капча??6-   $
??Left=?6D   $??508,249,0,0q?6_   $	??Top=?6t   $??93??6?   $??24??6?   $y?Hidden=?6?   6?   ?? 5   
   $??
Логин??6   $
??Left=?6    $??296,110,0,0q?6;   $	??Top=?6P   ?? 5   
   $??Пароль??6   $
??Left=?6!   $??296,165,0,0q?6<   $	??Top=?6Q   ?? 5   
   $??Авторизация??6   $
??Left=?6&   $??
358,10,0,0q?6A   $	??Top=?6U   5      5      