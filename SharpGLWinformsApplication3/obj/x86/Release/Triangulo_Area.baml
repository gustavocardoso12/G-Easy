   M S B A M L   `   `   `  ����   SharpGLWinformsApplication3    MiniPaint.Triangulo_Area   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  $	��378��.��� $	��529��$	��378��.+�&   HelixToolkit.Wpf.HelixViewport3D  -      Name$  camera�� J� Opacity$	 0.8Q�$
��Left=�$	��618��   ShowCameraTarget .     ShowViewCube .  $��-120,32,-120,195q�   ChangeFieldOfViewCursor$ No��   RotateCursor$
 Hand�� J� 	AllowDrop .    CameraRotationMode$ 	Trackball=� J� RenderTransformOrigin$ 0.561,0.509&�	   RotateGesture	 b� 
 b� MouseAction$
 	LeftClicke� b� 	Modifiers$  f�   Children. g�  g� Content h� .���  � Geometry k� -   mesh�� k� 	Positions �    k� Normals �   ��  � Material u�  u� Brush
 ��� � � BackMaterial u� 
 ��ح� j� 	Transform ��  �� Rotation ��  �� Axis$ 0 1 05� �� Angle ��  �� ElementName$
 horz�� �� Path$ Value���  �� Color$
 Gray��t� $ Green�� t� 	Direction$ 2 -3 -15�� $
��Left=�$	��100��$��
52,176,0,0q�$	��Top=�$	��100��$��2��� $
��Left=�$	��100��$��110,176,0,0q�$	��Top=�$	��100��$��1��� $
��Left=�$	��207��$��
76,294,0,0q�$	��Top=�$	��240�� � RowDefinitions �� $
��116* ��� $	��91* �.+�� $
��Left=�$��-72,0,-317,-142q�$	��629��$ 0.506,0.675&�$��2��.+��� $
��Area��$
��Left=�$��	10,10,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��	57,12,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $�� Base��$
��Left=�$��
104,12,0,0q�$	��Top=�$��Verdana)�$��14(��� $��/��$
��Left=�$��
255,13,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��*��$
��Left=�$��
153,13,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��2��$
��Left=�$��
276,13,0,0q�$	��Top=�$��Verdana)�$��14(��� $��=��$
��Left=�$��	57,41,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��*��$
��Left=�$��
199,43,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� -   $��  Calcular Área ��$
��Left=�$��54��$��
83,155,0,0q�$	��Top=�$	��195��$��Verdana)�$��14(����	#FFDAE6F0$��4q����	#FF2F463C���	#FFFBFBFB$
��Bold"��� $��(��$
��Left=�$��	83,12,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��Altura��$
��Left=�$��
177,13,0,0q�$	��Top=�$��Verdana)�$��14(��� $��)��$
��Left=�$��
234,13,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��)��$
��Left=�$��
314,41,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��(��$
��Left=�$��	83,43,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��Área��$
��Left=�$��
10,118,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��
62,118,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $
��Area��$
��Left=�$��	10,39,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��/��$
��Left=�$��
330,42,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��2��$
��Left=�$��
351,42,0,0q�$	��Top=�$��Verdana)�$��14(��� -    ��Name$ altura��$
��Left=�$��26��$��Verdana)�$��14(�$��
234,47,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� $��6��$��Verdana)�$��14(�$��26��$	��100���� $��7��$��Verdana)�$��14(�$��26��$	��100���� -   $ _base��$
��Left=�$��26��$��Verdana)�$��14(�$��
112,46,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� $��6��$��Verdana)�$��14(�$��26��$	��100���� $��7��$��Verdana)�$��14(�$��26��$	��100���� $��/��$
��Left=�$��
123,74,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��2��$
��Left=�$��
144,74,0,0q�$	��Top=�$��Verdana)�$��14(��� $��Área��$
��Left=�$��	10,75,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��	62,77,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� -    ��Name$	 res��$�� ��$��Right=�$��
0,75,190,0q�$	��Top=�$��Verdana)�$��14(�$��40���� -   $ res_Copy��$�� ��$
��Left=�$	��Top=�$��Verdana)�$��14(�$��91��$��1��$��20,0,0,0q�