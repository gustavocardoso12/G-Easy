   M S B A M L   `   `   `  ����   SharpGLWinformsApplication3    MiniPaint.Quadrado_Area   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  $	��378��.��� $	��529��$	��378��.+�&   HelixToolkit.Wpf.HelixViewport3D  -      Name$  camera�� J� Opacity$	 0.8Q�$
��Left=�$	��618��   ShowCameraTarget .     ShowViewCube .  $��-120,32,-120,195q�   ChangeFieldOfViewCursor$ No��   RotateCursor$
 Hand�� J� 	AllowDrop .    CameraRotationMode$ 	Trackball=� J� RenderTransformOrigin$ 0.561,0.509&�	   RotateGesture	 b� 
 b� MouseAction$
 	LeftClicke� b� 	Modifiers$  f�&   CoordinateSystemLabelForeground ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FFEE0404��$ 1Q�   Children. $  HelixToolkit.Wpf.DefaultLights  (  "HelixToolkit.Wpf.CuttingPlaneGroup  .2�(  "HelixToolkit.Wpf.RectangleVisual3D  -   quadrado��   Origin$ 0.1,0.1,1.41�   LengthDirection$ 0.2,2,55�   Length$	 3.5Q�   Width$	 3.5Q�$  HelixToolkit.Wpf.MeshElement3D   Fill �	#FF01EB80� $
��Left=�$	��182��$��
56,332,0,0q�$	��Top=�$	��269��.+��� $��Área��$
��Left=�$��	10,10,0,0q�$	��Top=�$��Verdana)�$��14(��� $��=��$
��Left=�$��	60,10,0,0q�$	��Top=�$��Verdana)�$��14(��� $��Lado²��$
��Left=�$��	86,10,0,0q�$	��Top=�$��Verdana)�$��14(��� $��Área��$
��Left=�$��	10,37,0,0q�$	��Top=�$��Verdana)�$��14(��� $��=��$
��Left=�$��	60,37,0,0q�$	��Top=�$��Verdana)�$��14(��� -    ��Name$
 lado��$
��Left=�$��26��$��Verdana)�$��14(�$��	90,41,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� $��6��$��Verdana)�$��14(�$��26��$	��100���� $��7��$��Verdana)�$��14(�$��26��$	��100���� $��2��$
��Left=�$��
160,22,0,0q�$	��Top=�$��Verdana)�$��14(��� $��Área��$
��Left=�$��	10,69,0,0q�$	��Top=�$��Verdana)�$��14(��� $��=��$
��Left=�$��	60,69,0,0q�$	��Top=�$��Verdana)�$��14(��� -    ��Name$	 res��$�� ��$
��Left=�$��	86,69,0,0q�$	��Top=�$��75��$��Verdana)�$��14(��� -   $+��%        Calcular Área               ��$
��Left=�$��54��$��
51,118,0,0q�$	��Top=�$	��157��$��Arial)�$��14(����	#FFDAE6F0$��4q����	#FF2F463C���	#FFFBFBFB$
��Bold"�