   M S B A M L   `   `   `  ����   SharpGLWinformsApplication3#    MiniPaint.AreaLateralCilindro   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  $	��378��.��� $	��529��$	��378��.+�&   HelixToolkit.Wpf.HelixViewport3D  -      Name$  camera�� J� Opacity$	 0.8Q�$
��Left=�$	��618��   ShowCameraTarget .     ShowViewCube .  $��-105,93,-135,134q�   ChangeFieldOfViewCursor$ No��   RotateCursor$
 Hand�� J� 	AllowDrop .  � 	Resources  
  Brush2 �� Color��%   &	        �� $ 	#FFF13315��	   RotateGesture	 b� 
 b� MouseAction$
 	LeftClicke� b� 	Modifiers$  f�&   CoordinateSystemLabelForeground ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FFEE0404��$ 1Q�   Children. $  HelixToolkit.Wpf.DefaultLights  ,  &HelixToolkit.Wpf.TruncatedConeVisual3D  -   cilindroobjeto��$  HelixToolkit.Wpf.MeshElement3D   Fill �	#7F01EB80   	TopRadius$	 1.5Q�   Height$ 4Q�   
BaseRadius$	 1.5Q�   BaseCap .     TopCap .  � $
��Left=�$	��184��$��260,225,-122,0q�$	��Top=�$	��240��.+�� $
��Left=�$	��207��$��-272,45,0,-68q�$	��Top=�$	��240�� � RowDefinitions �� $
��116* ��� $	��91* �.+�� $
��Left=�$��10,41,-215,-183q�$	��445�� J� RenderTransformOrigin$ 0.506,0.675&�$��2��.+��� $��Al��$
��Left=�$��	10,10,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��	36,13,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� -    ��Name$
 Raio��$
��Raio��$
��Left=�$��
105,14,0,0q�$	��Top=�$��Verdana)�$��14(��� $��*��$
��Left=�$��
229,18,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��*��$
��Left=�$��
155,17,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��Altura��$
��Left=�$��
253,13,0,0q�$	��Top=�$��Verdana)�$��14(��� -   $��Calcular área lateral��$
��Left=�$��54��$��
81,152,0,0q�$	��Top=�$	��186��$��Verdana)�$��14(����	#FF070E13$��4q����	#FF2F463C���	#FFF5F0F0$
��Bold"��� $��2��$
��Left=�$��	60,14,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��*��$
��Left=�$��	81,16,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $
��(π)��$
��Left=�$��181,324,0,0q�$	��Top=�$��Verdana)�$��16(�� $
��Left=�$��290,317,-215,-366q�$	��303��$ 0.506,0.675&�.+��� $��*��$
��Left=�$��
-16,41,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��Al��$
��Left=�$��-283,41,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��-262,41,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��Al��$
��Left=�$��-283,77,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��-257,77,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��=��$
��Left=�$��-258,104,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��Al��$
��Left=�$��-283,106,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��*��$
��Left=�$��-152,81,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��*��$
��Left=�$��-209,43,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��*��$
��Left=�$��-108,43,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� -    ��Name$ Altura��$
��Left=�$��26��$��Verdana)�$��14(�$��290,358,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� $��2��$
��Left=�$��
54,355,0,0q�$	��Top=�$��28��$��Verdana)�$��16(��� -   $ doisvezesraio��$�� ��$
��Left=�$��
60,394,0,0q�$	��Top=�$��Verdana)�$��15(�$��74���� -   $ Raio1��$
��Left=�$��26��$��Verdana)�$��14(�$��110,358,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� -    ��Name$ PI_Copy��$
��Left=�$��23��$��203,359,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��76��$ -0.014,-0.141&�$��Verdana)�$��14(�$
��3.14�� �� 
IsReadOnly . �� -	   $	 res��$�� ��$
��Left=�$��
60,423,0,0q�$	��Top=�$��Verdana)�$��15(�$��74���� -
   $ pivezesaltura��$�� ��$
��Left=�$��181,395,0,0q�$	��Top=�$��Verdana)�$��15(�$��74��