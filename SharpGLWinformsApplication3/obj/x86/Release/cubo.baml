   M S B A M L   `   `   `  ����   SharpGLWinformsApplication3    MiniPaint.cubo   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  $	��378��.��� $	��529��$	��378��  � RowDefinitions  �� $
��423* ��� $
��106* �.+�&   HelixToolkit.Wpf.HelixViewport3D  -     Name$ camera�� J� Opacity$	 0.8Q�$
��Left=�$	��618��   ShowCameraTarget .     ShowViewCube .  $��-117,67,-123,55q�   ChangeFieldOfViewCursor$ No��   RotateCursor$
 Hand�� J� 	AllowDrop .  � 	Resources  
  Brush2	 �� Color��%   &	        �� $	 	#FFF13315��
   RotateGesture
 b�  b� MouseAction$ 	LeftClicke� b� 	Modifiers$  f�&   CoordinateSystemLabelForeground ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FFEE0404��$ 1Q�   Children. $  HelixToolkit.Wpf.DefaultLights  #  HelixToolkit.Wpf.CubeVisual3D  -   	cubo1��$  HelixToolkit.Wpf.MeshElement3D   Fill �	#7F01EB80   
SideLength$ 3Q�� $
��Left=�$	��184��$��261,240,-123,0q�$	��Top=�$	��240��$��2��.+�� $
��Left=�$	��207��$��-272,45,0,-68q�$	��Top=�$	��240��  �� $
��116* ��� $	��91* �.+�� $
��Left=�$��10,41,-215,-183q�$	��445�� J� RenderTransformOrigin$ 0.506,0.675&�$��2��.+��� $	��V  ��$
��Left=�$��	10,11,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��	46,12,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� -    ��Name$ Profundidade��$��Profundidade��$
��Left=�$��	62,15,0,0q�$	��Top=�$��Verdana)�$��14(��� $��*��$
��Left=�$��
247,17,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��*��$
��Left=�$��
173,17,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��Altura��$
��Left=�$��
190,15,0,0q�$	��Top=�$��Verdana)�$��14(��� -   $��Calcular Volume��$
��Left=�$��54��$��
81,140,0,0q�$	��Top=�$	��192��$��Verdana)�$��14(����	#FF070E13$��4q����	#FF2F463C���	#FFF5F0F0$
��Bold"��� $��Largura��$
��Left=�$��261,339,0,0q�$	��Top=�$��Verdana)�$��16(�� $
��Left=�$��291,329,-216,-378q�$	��303��$ 0.506,0.675&�$��2��.+��� $��*��$
��Left=�$��
-30,43,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��V��$
��Left=�$��-283,38,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��-252,41,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��=��$
��Left=�$��-252,68,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��V ��$
��Left=�$��-283,68,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��*��$
��Left=�$��-152,43,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� -    ��Name$ Altura��$
��Left=�$��26��$��Verdana)�$��14(�$��169,368,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� $��6��$��Verdana)�$��14(�$��26��$	��100���� -   $
 Prof��$
��Left=�$��26��$��Verdana)�$��14(�$��
61,368,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� $��6��$��Verdana)�$��14(�$��26��$	��100���� -   $	 res��$�� ��$
��Left=�$��
61,396,0,0q�$	��Top=�$��Verdana)�$��15(�$��74��$��2���� -   $ Largura��$
��Left=�$��26��$��Verdana)�$��14(�$��299,368,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� $��6��$��Verdana)�$��14(�$��26��$	��100��