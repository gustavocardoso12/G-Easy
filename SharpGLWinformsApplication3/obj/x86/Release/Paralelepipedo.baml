   M S B A M L   `   `   `  ����   SharpGLWinformsApplication3    MiniPaint.UserControl3   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  $	��378��.��� $	��529��$	��378��.+�&   HelixToolkit.Wpf.HelixViewport3D  -      Name$  camera�� J� Opacity$	 0.8Q�$
��Left=�$	��618��   ShowCameraTarget .     ShowViewCube .  $��-112,74,-128,153q�   ChangeFieldOfViewCursor$ No��   RotateCursor$
 Hand�� J� 	AllowDrop .    RotateGesture b�  b� MouseAction$ 	LeftClicke�	 b� 	Modifiers$	  f�&
   CoordinateSystemLabelForeground
 ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FFEE0404��$ 1Q�   Children. $  HelixToolkit.Wpf.DefaultLights  "  HelixToolkit.Wpf.BoxVisual3D  -   	Caixa��$  HelixToolkit.Wpf.MeshElement3D   Fill �	#FF01EB80   Height$ 5Q�   Length$ 8Q�   Width$ 2Q�� $
��Left=�$	��207��$��121,321,0,0q�$	��Top=�$	��240�� � RowDefinitions �� $
��116* ��� $	��91* �.+�� $
��Left=�$��-113,28,-92,-170q�$	��445�� J� RenderTransformOrigin$ 0.506,0.675&�$��2��.+��� $��V��$
��Left=�$��	10,10,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��	36,13,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��Comprimento��$
��Left=�$��	57,12,0,0q�$	��Top=�$��Verdana)�$��14(��� $��*��$
��Left=�$��
243,17,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��*��$
��Left=�$��
162,17,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��Altura��$
��Left=�$��
186,12,0,0q�$	��Top=�$��Verdana)�$��14(��� $��V��$
��Left=�$��	10,41,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��	36,40,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� $��*��$
��Left=�$��
138,44,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��Largura��$
��Left=�$��
262,12,0,0q�$	��Top=�$��Verdana)�$��14(��� $��*��$
��Left=�$��
243,44,0,0q�$	��Top=�$ 0.097,-0.387&�$��Verdana)�$��14(��� $��V��$
��Left=�$��	10,72,0,0q�$	��Top=�$��Verdana)�$��16(�$ 
0.434,-0.4&��� $��=��$
��Left=�$��	36,73,0,0q�$	��Top=�$ -0.278,-0.444&�$��Verdana)�$��14(��� -    ��Name$ 	resultado��$�� ��$
��Left=�$��	62,72,0,0q�$	��Top=�$	��176��$��Verdana)�$��14(��� -   $&��   Calcular Volume               ��$
��Left=�$��54��$��105,104,0,0q�$	��Top=�$	��157��$��Verdana)�$��14(����	#FFDAE6F0$��4q����	#FF2F463C���	#FFFBFBFB$
��Bold"��� -    ��Name$ Altura��$
��Left=�$��26��$��Verdana)�$��14(�$��	51,71,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� -   $ Largura��$
��Left=�$��26��$��Verdana)�$��14(�$��
161,71,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� -   $ label2��$�� ��$
��Left=�$��
-40,99,0,0q�$	��Top=�$��Verdana)�$��14(�$	��108��$��2���� -   $ Comprimento��$��Right=�$��26��$��Verdana)�$��14(�$��-42,70,213,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100��