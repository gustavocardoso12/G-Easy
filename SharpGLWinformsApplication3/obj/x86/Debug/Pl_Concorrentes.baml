   M S B A M L   `   `   `  ����  SharpGLWinformsApplication3    MiniPaint.Pl_Concorrentes   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  5      $	��378��5   #   .��5	      � $	��529��6   $	��378��6   .+�5
   
   &   HelixToolkit.Wpf.HelixViewport3D  -   5           Name$  camera��5
       J� Opacity$	 0.8Q�6.   $
��Left=�6<   $	��618��6W      ShowCameraTarget .     ShowViewCube .  $��-105,104,-135,123q�6�      ChangeFieldOfViewCursor$ No��6�      RotateCursor$
 Hand��6�    J� 	AllowDrop .    CameraRotationMode$ 	Trackball=�6�    J� RenderTransformOrigin$ 0.561,0.509&�6  	   RotateGesture	 5      b� 5      
 b� MouseAction$
 	LeftClicke�6    b� 	Modifiers$  f�67   &   CoordinateSystemLabelForeground 5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ 	#FFEE0404��6#   $ 1Q�65   5         Children. 5      $  HelixToolkit.Wpf.DefaultLights  (  "HelixToolkit.Wpf.CuttingPlaneGroup  5      .2�5      (  "HelixToolkit.Wpf.RectangleVisual3D  -   5        quadrado��   Origin$ 
0.2,-1,3.71�5   9      LengthDirection$ 0.2,2,75�6N      Length$ 1Q�6i      Width$ 10Q�6t   $  HelixToolkit.Wpf.MeshElement3D   Fill
 �����   	DivLength$ 10��6�      DivWidth$ 20��6�     5      -   5        	quadrado1��$ 
0.1,-1,3.41�5   :   $ 0.2,2,55�6O   $ 5Q�6i   $ 5Q�6t   
 �   �6~   5      5      �� 5   
   $!��P1 // P2 =A                ��6   $��Verdana)�5      $��24(�6'   $
��Left=�65   $��
80,411,0,0q�6P   $	��Top=�6d   5       5!      