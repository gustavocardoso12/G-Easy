   M S B A M L   `   `   `  ����   SharpGLWinformsApplication3    MiniPaint.Esfera_Setor   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  $	��378��.��� -     �Name$  grade2��$��
0,0,0,-353q�$	��378��$	��529��.+�&   HelixToolkit.Wpf.HelixViewport3D  -     Name$ camera�� J� Opacity$	 0.8Q�$
��Left=�$	��524��   ShowCameraTarget .     ShowViewCube .  $��-66,-202,-80,370q�   ChangeFieldOfViewCursor$ No��   RotateCursor$
 Hand�� J� 	AllowDrop .    RotateGesture b� 	 b� MouseAction$	 	LeftClicke�
 b� 	Modifiers$
  f�&   CoordinateSystemLabelForeground ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FFEE0404��$ 1Q�   Children. $  HelixToolkit.Wpf.DefaultLights  (  "HelixToolkit.Wpf.CuttingPlaneGroup  .2�(  "HelixToolkit.Wpf.RectangleVisual3D  -   	plano��   Origin$ 0.05,0.10,0.41�   LengthDirection$ 0.3,2,25�   Length$	 3.5Q�   Width$ 5Q�$  HelixToolkit.Wpf.MeshElement3D   Fill �	#FF0E2BAC%  HelixToolkit.Wpf.SphereVisual3D  -   EsferaObjeto�� �	#4C01EB80   PhiDiv$	 100��   ThetaDiv$	 100��   Radius$ 2Q�� -   $  
gradesetor��$
��Left=�$	��282��$��
21,85,-8,0q�$	��Top=�$	��365��.+��� $��Setor Circular²��$
��Left=�$��	10,38,0,0q�$	��Top=�$��Verdana)�$��14(��� $��=��$
��Left=�$��
122,38,0,0q�$	��Top=�$��Verdana)�$��14(��� $��Raio²��$
��Left=�$��
148,38,0,0q�$	��Top=�$��Verdana)�$��14(��� $��+��$
��Left=�$��
201,38,0,0q�$	��Top=�$��Verdana)�$��14(��� $��Distância²��$
��Left=�$��
227,38,0,0q�$	��Top=�$��Verdana)�$��14(��� $��Setor Circular²��$
��Left=�$��	10,78,0,0q�$	��Top=�$��Verdana)�$��14(��� $��=��$
��Left=�$��
122,77,0,0q�$	��Top=�$��Verdana)�$��14(��� -    ��Name$
 Raio��$
��Left=�$��26��$��Verdana)�$��14(�$��
143,81,0,0q�$	��Top=�$��69��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� $��6��$��Verdana)�$��14(�$��26��$	��100���� $��+��$
��Left=�$��
217,77,0,0q�$	��Top=�$��Verdana)�$��14(��� -    ��Name$ 	Distancia��$
��Left=�$��23��$��
243,81,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��62��$��Verdana)�$��14(�{�.  �� $��Setor Circular²��$
��Left=�$��
10,113,0,0q�$	��Top=�$��Verdana)�$��14(��� $��=��$
��Left=�$��122,113,0,0q�$	��Top=�$��Verdana)�$��14(��� -    ��Name$ raioaoquadrado��$�� ��$
��Left=�$��148,114,0,0q�$	��Top=�$��61��$��Verdana)�$��14(��� $��+��$
��Left=�$��217,113,0,0q�$	��Top=�$��Verdana)�$��14(��� -	   $ distanciaaoquadrado��$�� ��$
��Left=�$��243,114,0,0q�$	��Top=�$��61��$��Verdana)�$��14(��� $��Setor Circular��$
��Left=�$��
10,145,0,0q�$	��Top=�$��Verdana)�$��14(��� $��=��$
��Left=�$��122,145,0,0q�$	��Top=�$��Verdana)�$��14(��� $��Raiz de ��$
��Left=�$��143,145,0,0q�$	��Top=�$��Verdana)�$��14(��� -
   $
 Raiz��$�� ��$
��Left=�$��214,145,0,0q�$	��Top=�$��61��$��Verdana)�$��14(��� $��Setor Circular��$
��Left=�$��
10,177,0,0q�$	��Top=�$��Verdana)�$��14(��� $��=��$
��Left=�$��122,177,0,0q�$	��Top=�$��Verdana)�$��14(��� -   $	 Res��$�� ��$
��Left=�$��148,178,0,0q�$	��Top=�$��61��$��Verdana)�$��14(��� -    ��Name$ botaoAT��$.��( Calcular Setor Circular                ��$
��Left=�$��
69,218,0,0q�$	��195��$��Verdana)�$��14(�
����  �$��4q����	#FF2F463C���	#FFFBFBFB$
��Bold"�$��54��$	��Top=��� $��²��$
��Left=�$��
201,65,0,0q�$	��Top=�$��18��$��Verdana)�$��16(��� $��²��$
��Left=�$��
297,65,0,0q�$	��Top=�$��18��$��Verdana)�$��16(�� -   $  gradeconfirmacao��$
��Left=�$	��162��$��10,113,-15,0q�$	��Top=�$	��383��.+��� $;��5Selecione um valor para distância entre raio e plano��$
��Left=�$��32��$��	10,10,0,0q�$	��Top=�$��Verdana)�$��14(��� -   $ texto��$
��Left=�$��26��$��Verdana)�$��14(�$��	77,84,0,0q�$	��Top=�$	��193��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� $��6��$��Verdana)�$��14(�$��26��$	��100���� -   $ botaoAT2��$��	Confirmar��$
��Left=�$��46��$��75,134,0,-18q�$	��Top=�$	��195��$��Verdana)�$��14(�
����  �$��4q����	#FF2F463C���	#FFFBFBFB$
��Bold"�