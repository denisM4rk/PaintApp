   M S B A M L   `   `   `  ????C  ?PaintApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PaintAppPaintApp  5   	       PaintApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PaintApp     5   	     ? Title$-  'Графический редактор??5   	   $	??450??6&   $	??860??63   $	??450??6?   $	??860??6O   ??5
      ?? 5   
   .??5      ?  ? Color$ 	LawnGreen??6    ? Offset$ 0Q?6-   6:   ? 5      $ White??6   $ 1Q?6)   66   5      .??5      ? .+?5   
   ?? -   5        $??	inkCanvas??5      $
??Left=?6&   $	??309??5      $??10,10,10,10q?6#   $??Center=?68   $	??830??6S   ]? 5   
   $	??Top=?6   $??2??6,   .+?5      c? $??Stretch=?6   $??41??62   .@?5      ?? -   5        .??5      ?? $??Images/1.png??6   $??28??63   $??29??6?   5       ?? 5!      ?? 5"      -   5        .??5#      ?? $??Images/3.png??6   $??30??63   $??35??6?   5$      ?? 5%      ?? 5&      -   5        .??5'      ?? $??Images/2.png??6   $??27??62   $??30??6>   5(      5)      5*      ?? 5,   
   -   5         ??Name$ sld_RedColor??5,      
???  ?? ? Minimum$ 0Q?68    ? Maximum$	 255Q?6D   $
??Left=?6R   $??Bottom=?5-      $??10q?62   $	??269??6>   6J   ?? 5.   
   -   5        $ sld_GreenColor??5.      
??? ? ?$ 0Q?6<   $	 255Q?6H   $??Center=?6V   $??Bottom=?5/      $??10q?61   $	??269??6=   6I   ?? 50   
   -   5        $ sld_BlueColor??50      
????  ?$ 0Q?6:   $	 255Q?6F   $??Right=?6T   $??10q?51      $??Bottom=?6"   $	??269??6=   6I   ?? 53   
   -   5         ??Name$
 lbl1??53      $
??Left=?6   $??105,35q?69   $??Bottom=?6I   ?? 55   
   $
??Left=?6   $
??5,30q?6+   $??Bottom=?69   .??6T   Выберите цвет6c   56      57      