   M S B A M L   `   `   `  ����  SharpGLWinformsApplication3    MiniPaint.AreaTotal_Cubo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  5      $	��378��5   #   .��5	      � $	��529��6   $	��378��6   .+�5
   
   &   HelixToolkit.Wpf.HelixViewport3D  -   5           Name$  camera��5
       J� Opacity$	 0.8Q�6.   $
��Left=�6<   $	��618��6W      ShowCameraTarget .     ShowViewCube .  $��-111,76,-129,151q�6�      ChangeFieldOfViewCursor$ No��6�      RotateCursor$
 Hand��6�    J� 	AllowDrop .    RotateGesture 5      b� 5       b� MouseAction$ 	LeftClicke�6   	 b� 	Modifiers$	  f�67   &
   CoordinateSystemLabelForeground
 5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ 	#FFEE0404��6#   $ 1Q�65   5         Children. 5      $  HelixToolkit.Wpf.DefaultLights  #  HelixToolkit.Wpf.CubeVisual3D  5      -   5        cubo��$  HelixToolkit.Wpf.MeshElement3D   Fill �	#3300FF17$��RightToLeft=�5         
SideLength$ 3Q�6D   5      �� 5   
   $
��Left=�6   $	��100��60   $��-34,119,0,0q�6=   $	��Top=�6R   $	��100��6j   � 5   
   $
��Left=�6   $	��196��6*   $��253,247,-165,0q�67   $	��Top=�6O   $	��290��6g   .+�5      �� $��4��6   $
��Left=�6    $��-98,149,0,0q�6;   $	��Top=�6P   $��Verdana)�6h   $��14(�6}   �� 5      -   5         ��Name$ Aresta��5      $
��Left=�6'   $��26��6C   $��Verdana)�6P   $��14(�6e   $��-50,149,0,0q�6t   $	��Top=�6�   $��69��6�   .@�5       �� $��1��6   $��Verdana)�6+   $��14(�6@   $��26��6N   $	��100��6Z   �� 5!      $��2��6   $��Verdana)�6,   $��14(�6A   $��26��6O   $	��100��6[   �� 5"      $��3��6   $��Verdana)�6+   $��14(�6@   $��26��6N   $	��100��6Z   �� 5#      $��4��6   $��Verdana)�6,   $��14(�6A   $��26��6O   $	��100��6[   �� 5$      $��5��6   $��Verdana)�6+   $��14(�6@   $��26��6N   $	��100��6Z   �� 5%      $��6��6   $��Verdana)�6,   $��14(�6A   $��26��6O   $	��100��6[   5(      �� 5*      $��*��6   $
��Left=�6    $��-74,150,0,0q�6;   $	��Top=�6P   $��Verdana)�6h   $��14(�6}   �� 5+      $��2��6   $
��Left=�6    $��
10,128,0,0q�6;   $	��Top=�6O   $��Verdana)�6g   $��14(�6|   �� 5,      $��=��6   $
��Left=�6    $��-128,147,0,0q�6;   $	��Top=�6Q   $��Verdana)�6i   $��14(�6~   �� 5-      $��=��6   $
��Left=�6    $��-128,177,0,-8q�6;   $	��Top=�6R   $��Verdana)�6j   $��14(�6   5.      �� 5/   
   $��Área lateral��6   $
��Left=�6'   $��29,395,0,-129q�6B   $��Verdana)�6Y   $��14(�6n   �� 50   
   -   5         ��Name$ 	Resultado��50      $�� ��6#   $
��Left=�6.   $��292,214,-76,0q�6I   $	��Top=�6`   $	��162��6x   $��Verdana)�6�   $	��128��6�   �� 51   
   $��	Resultado��6   $
��Left=�6$   $��29,426,0,-160q�6?   $��Verdana)�6V   $��14(�6k   �� 52   
   -   5        $ 
Resultado1��52      $�� ��6$   $
��Left=�6/   $��35��6J   $��154,425,0,0q�6V   $	��Top=�6k   $	��142��6�   �� 53   
   -   5        $�� Calcular área total��53      $
��Left=�60   $��54��6K   $��108,465,0,0q�6W   $	��Top=�6l   $	��188��6�   $��Verdana)�6�   $��14(�6�   ���	#FFDAE6F0$��4q�6�   ���	#FF2F463C���	#FFFBFBFB$
��Bold"�6"  56      57      