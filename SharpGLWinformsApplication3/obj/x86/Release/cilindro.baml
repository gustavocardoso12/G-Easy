   M S B A M L   `   `   `  ���� V  RSharpGLWinformsApplication3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MiniPaint	MiniPaint      MiniPaint.UserControl4   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  #localclr-namespace:MiniPaint  -     >�Name$  cilindro��$	��378�� � 	Resources  
  Brush1 �� Color��%   &	        �� $ 	#FFF13315��.��� $	��529��$	��378��.+�&   HelixToolkit.Wpf.HelixViewport3D  -     Name$ camera�� J� Opacity$	 0.8Q�$
��Left=�$	��618��   ShowCameraTarget .     ShowViewCube .  $��-105,93,-135,134q�   ChangeFieldOfViewCursor$ No��   RotateCursor$
 Hand��	 J� 	AllowDrop	 .   
 Brush2��%   &	       �� $ 	#FFF13315��
   RotateGesture
 b�  b� MouseAction$ 	LeftClicke� b� 	Modifiers$  f�&   CoordinateSystemLabelForeground ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FFEE0404��$ 1Q�   Children. $  HelixToolkit.Wpf.DefaultLights  ,  &HelixToolkit.Wpf.TruncatedConeVisual3D  -   cilindroobjeto��$  HelixToolkit.Wpf.MeshElement3D   Fill �	#FF01EB80   	TopRadius$	 1.5Q�   Height$ 4Q�   
BaseRadius$	 1.5Q�� $
��Left=�$	��184��$��263,197,-125,0q�$	��Top=�$	��240��.+�� $
��Left=�$	��207��$��-272,45,0,-68q�$	��Top=�$	��240�� � RowDefinitions �� $
��116* ��� $	��91* �.+�� $
��Left=�$��10,41,-215,-183q�$	��445�� J� RenderTransformOrigin$ 0.506,0.675&�$��2��.+��� $��V��$
��Left=�$��	10,10,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��	36,13,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� -    ��Name$
 Raio��$
��Raio��$
��Left=�$��	57,12,0,0q�$	��Top=�$��Verdana)�$��14(��� $��*��$
��Left=�$��
156,17,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��*��$
��Left=�$��
102,17,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��Altura��$
��Left=�$��
180,13,0,0q�$	��Top=�$��Verdana)�$��14(��� -   $&��   Calcular Volume               ��$
��Left=�$��54��$��
88,194,0,0q�$	��Top=�$	��144��$��Verdana)�$��14(����	#FF070E13$��4q����	#FF2F463C���	#FFF5F0F0$
��Bold"��� $��²��$
��Left=�$��88,5,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $
��(π)��$
��Left=�$��121,295,0,0q�$	��Top=�$��Verdana)�$��16(�� $
��Left=�$��293,289,-218,-338q�$	��303��$ 0.506,0.675&�.+��� $��*��$
��Left=�$��
-47,45,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��V��$
��Left=�$��-283,41,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��-262,41,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��*��$
��Left=�$��-152,44,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��V��$
��Left=�$��-283,77,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��-257,77,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��V��$
��Left=�$��-283,141,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��-258,104,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��V��$
��Left=�$��-283,106,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��-257,141,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��*��$
��Left=�$��-152,81,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��*��$
��Left=�$��
-47,75,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��*��$
��Left=�$��-152,110,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� -    ��Name$ PI��$
��Left=�$��23��$��166,333,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��76��$ -0.014,-0.141&�$��Verdana)�$��14(�$
��3.14�� �� 
IsReadOnly . �� -    ��Name$ Raio1��$
��Left=�$��26��$��Verdana)�$��14(�$��
50,335,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� $��²��$
��Left=�$��119,320,0,0q�$	��Top=�$��18��$��Verdana)�$��16(��� -   $ label1��$�� ��$
��Left=�$��
63,366,0,0q�$	��Top=�$��Verdana)�$��15(�$��74���� -	   $ Altura��$
��Left=�$��26��$��Verdana)�$��14(�$��276,335,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� -
   $ PI_Copy��$
��Left=�$��23��$��166,367,0,0q�$
 Wrap=�$	��Top=�$��76��$ -0.014,-0.141&�$��Verdana)�$��14(�$
��3.14�� . �� -   $ label2��$�� ��$
��Left=�$��
63,395,0,0q�$	��Top=�$��Verdana)�$��15(�$��74���� -   $ label3��$�� ��$
��Left=�$��
57,428,0,0q�$	��Top=�$��Verdana)�$��15(�$	��174���� -   $ label4��$�� ��$
��Left=�$��276,367,0,0q�$	��Top=�$��Verdana)�$��15(�$��74���� -   $ label4_Copy��$�� ��$
��Left=�$��168,395,0,0q�$	��Top=�$��Verdana)�$��15(�$��74��