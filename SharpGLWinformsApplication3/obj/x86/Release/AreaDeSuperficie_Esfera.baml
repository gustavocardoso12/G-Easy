   M S B A M L   `   `   `  ����   SharpGLWinformsApplication3'    !MiniPaint.AreaDeSuperficie_Esfera   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  $	��378��.��� $	��378��$	��529��$��Stretch=�$��Stretch=�.+�&   HelixToolkit.Wpf.HelixViewport3D  -      Name$  camera�� J� Opacity$	 0.8Q�$
��Left=�$	��524��   ShowCameraTarget .     ShowViewCube .  $��-72,0,-74,168q�   ChangeFieldOfViewCursor$ No��   RotateCursor$
 Hand�� J� 	AllowDrop .    RotateGesture b�  b� MouseAction$ 	LeftClicke�	 b� 	Modifiers$	  f�&
   CoordinateSystemLabelForeground
 ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FFEE0404��$ 1Q�   Children. $  HelixToolkit.Wpf.DefaultLights  (  "HelixToolkit.Wpf.CuttingPlaneGroup  .2�%  HelixToolkit.Wpf.SphereVisual3D  -   
Esfera��$  HelixToolkit.Wpf.MeshElement3D   Fill �	#FF01EB80   ThetaDiv$ 2��   PhiDiv$ 53��   Radius$ 2Q�  -   EsferaObjeto�� �	#3300FF17$	 100��$	 100��$ 2Q�� -    �Name$ 	Agrupador��$
��Left=�$	��337��$��-1,235,0,-43q�$	��Top=�$	��367��.+��� $��²��$
��Left=�$��
282,75,0,0q�$	��Top=�$��18��$��Verdana)�$��16(��� -    ��Name$	 Res��$�� ��$
��Left=�$��
90,151,0,0q�$	��Top=�$��Verdana)�$��14(�$	��104��� -   $ Grade��$
��Left=�$��
28,45,0,63q�$	��303�� J� RenderTransformOrigin$ 0.506,0.675&�.+��� -   $ label4��$��As��$
��Left=�$��0,13,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� -   $ label5��$��=��$
��Left=�$��	29,13,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� -	   $ label6��$��4��$
��Left=�$��	57,13,0,0q�$	��Top=�$��Verdana)�$��14(��� -
   $ label7��$��*��$
��Left=�$��	75,43,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��*��$
��Left=�$��
147,16,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��Raio²��$
��Left=�$��
176,16,0,0q�$	��Top=�$��Verdana)�$��14(��� $��As��$
��Left=�$��0,40,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��	29,41,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� -   $ label8��$
��(π)��$
��Left=�$��
101,12,0,0q�$	��Top=�$��Verdana)�$��16(�$ 0.345,0.345&��� -   $ label��$��*��$
��Left=�$��
160,43,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��As��$
��Left=�$��2,71,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��	36,71,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��*��$
��Left=�$��
147,71,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��As��$
��Left=�$��	4,105,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��
36,107,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� -   $&��  Calcular a área da superfície��$
��Left=�$��44��$��
10,139,0,0q�$	��Top=�$	��264��$��Verdana)�$��14(����	#FF070E13$��4q����	#FF2F463C$
��Bold"����	#FFF7F1F1�� -   $ label6_Copy��$��4��$
��Left=�$��	55,42,0,0q�$	��Top=�$��Verdana)�$��14(��� -   $ label7_Copy��$��*��$
��Left=�$��	77,16,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� -    ��Name$ PI��$
��Left=�$��23��$��	99,44,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��46��$ -0.014,-0.141&�$��Verdana)�$��14(�$
��3,14�� �� 
IsReadOnly . �� -   $ quatrovezespi��$�� ��$
��Left=�$��
90,119,0,0q�$	��Top=�$��Verdana)�$��14(�$��74���� -   $ raioaoquadrado��$�� ��$
��Left=�$��203,116,0,0q�$	��Top=�$��Verdana)�$��14(�$��74���� -    ��Name$
 Raio��$
��Left=�$��26��$��Verdana)�$��14(�$��211,325,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� $��6��$��Verdana)�$��14(�$��26��$	��100���� $��7��$��Verdana)�$��14(�$��26��$	��100���� $��8��$��Verdana)�$��14(�$��26��$	��100���� $��9��$��Verdana)�$��14(�$��26��$	��100���� $��10��$��Verdana)�$��14(�$��26��$	��100���� $��11��$��Verdana)�$��14(�$��26��$	��100��