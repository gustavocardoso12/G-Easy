   M S B A M L   `   `   `  ����  SharpGLWinformsApplication3     MiniPaint.AreaLateral_Cubo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  5      $	��378��5   #   .��5	      � $	��529��6   $	��378��6   .+�5
   
   &   HelixToolkit.Wpf.HelixViewport3D  -   5           Name$  camera��5
       J� Opacity$	 0.8Q�6.   $
��Left=�6<   $	��618��6W      ShowCameraTarget .     ShowViewCube .  $��-111,76,-129,151q�6�      ChangeFieldOfViewCursor$ No��6�      RotateCursor$
 Hand��6�    J� 	AllowDrop .    ResetCameraKeyGesture$
 Home��6�      RotateGesture 5      b� 5      	 b� MouseAction$	 	LeftClicke�6   
 b� 	Modifiers$
  f�67   &   CoordinateSystemLabelForeground 5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ 	#FFEE0404��6#   $ 1Q�65   5         Children. 5      $  HelixToolkit.Wpf.DefaultLights  #  HelixToolkit.Wpf.CubeVisual3D  5      -   5        cubo��$  HelixToolkit.Wpf.MeshElement3D   Fill �	#3300FF17$��RightToLeft=�5         
SideLength$ 3Q�6D   5      � 5   
   $
��Left=�6   $	��196��6*   $��279,252,-191,0q�67   $	��Top=�6O   $	��290��6g    � RowDefinitions 5      �� 5      $��5* �6    �� 5      $��2* �6    .+�5!      �� $��6��6   $
��Left=�6    $��	-98,9,0,0q�6;   $	��Top=�6N   $��Verdana)�6f   $��14(�6{   $��1��6�   �� 5#      -   5         ��Name$ Aresta��5#      $
��Left=�6'   $��26��6C   $��Verdana)�6P   $��14(�6e   $��	-55,9,0,0q�6t   $	��Top=�6�   $��69��6�   $��1��6�   .@�5$      �� $��1��6   $��Verdana)�6+   $��14(�6@   $��26��6N   $	��100��6Z   �� 5%      $��2��6   $��Verdana)�6,   $��14(�6A   $��26��6O   $	��100��6[   �� 5&      $��3��6   $��Verdana)�6+   $��14(�6@   $��26��6N   $	��100��6Z   �� 5'      $��4��6   $��Verdana)�6,   $��14(�6A   $��26��6O   $	��100��6[   �� 5(      $��5��6   $��Verdana)�6+   $��14(�6@   $��26��6N   $	��100��6Z   �� 5)      $��6��6   $��Verdana)�6,   $��14(�6A   $��26��6O   $	��100��6[   5,      �� 5-       J� IsHitTestVisible .  $
��(cm)��61   $��Center=�6=   $
��Left=�6X   $��340,18,-50,38q�6s   
�������$��1��6�   ��5.      �� 5/       �� 
TargetType" ��6   .�50      ��  �� Property � y� �� Value$ 	Collapsed=�67    �� Triggers 51      �� 52       �� Binding 6*   �� *Text+ �� ElementName$ textBox1�� �� Value  6Y   .a�53   "   ��  � y�$ Visible=�6?   54      56      58      �� 59      $��*��6   $
��Left=�6    $��
-74,10,0,0q�6;   $	��Top=�6O   $��Verdana)�6g   $��14(�6|   $��1��6�   �� 5:      $��2��6   $
��Left=�6    $��
10,131,0,0q�6;   $	��Top=�6O   $��Verdana)�6g   $��14(�6|   $��2��6�   �� 5;      $��=��6   $
��Left=�6    $��
-128,7,0,0q�6;   $	��Top=�6O   $��Verdana)�6g   $��14(�6|   $��1��6�   �� 5<      $��=��6   $
��Left=�6    $��-128,37,0,-8q�6;   $	��Top=�6Q   $��Verdana)�6i   $��14(�6~   $��1��6�   5=      �� 5>   
   $��Área total��6   $
��Left=�6%   $��55,400,0,-134q�6@   $��Verdana)�6W   $��14(�6l   �� 5?   
   $��Área total��6   $
��Left=�6%   $��55,431,0,-165q�6@   $��Verdana)�6W   $��14(�6l   �� 5@   
   -   5         ��Name$ 
Resultado1��5@      $��Verdana)�6$   $��14(�69   $�� ��6G   $
��Left=�6R   $��35��6m   $��180,430,0,0q�6y   $	��Top=�6�   $	��142��6�   �� 5A   
   -   5        $��Calcular área total��5A      $
��Left=�6/   $��54��6J   $��105,465,0,0q�6V   $	��Top=�6k   $	��171��6�   $��Verdana)�6�   $��14(�6�   ���	#FFDAE6F0$��4q�6�   ���	#FF2F463C���	#FFFBFBFB$
��Bold"�6!  5D      5E      