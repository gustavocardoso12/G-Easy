   M S B A M L   `   `   `  ����   SharpGLWinformsApplication3     MiniPaint.AreaLateral_Cubo   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  $	��378��.��� $	��529��$	��378��.+�&   HelixToolkit.Wpf.HelixViewport3D  -      Name$  camera�� J� Opacity$	 0.8Q�$
��Left=�$	��618��   ShowCameraTarget .     ShowViewCube .  $��-111,76,-129,151q�   ChangeFieldOfViewCursor$ No��   RotateCursor$
 Hand�� J� 	AllowDrop .    ResetCameraKeyGesture$
 Home��   RotateGesture b� 	 b� MouseAction$	 	LeftClicke�
 b� 	Modifiers$
  f�&   CoordinateSystemLabelForeground ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FFEE0404��$ 1Q�   Children. $  HelixToolkit.Wpf.DefaultLights  #  HelixToolkit.Wpf.CubeVisual3D  -   cubo��$  HelixToolkit.Wpf.MeshElement3D   Fill �	#3300FF17$��RightToLeft=�   
SideLength$ 3Q�� $
��Left=�$	��196��$��279,252,-191,0q�$	��Top=�$	��290�� � RowDefinitions �� $��5* ��� $��2* �.+��� $��6��$
��Left=�$��	-98,9,0,0q�$	��Top=�$��Verdana)�$��14(�$��1���� -    ��Name$ Aresta��$
��Left=�$��26��$��Verdana)�$��14(�$��	-55,9,0,0q�$	��Top=�$��69��$��1��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� $��6��$��Verdana)�$��14(�$��26��$	��100����  J� IsHitTestVisible .  $
��(cm)��$��Center=�$
��Left=�$��340,18,-50,38q�
�������$��1������  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=� �� Triggers ��  �� Binding �� *Text+ �� ElementName$ textBox1�� �� Value  .a���  � y�$ Visible=��� $��*��$
��Left=�$��
-74,10,0,0q�$	��Top=�$��Verdana)�$��14(�$��1���� $��2��$
��Left=�$��
10,131,0,0q�$	��Top=�$��Verdana)�$��14(�$��2���� $��=��$
��Left=�$��
-128,7,0,0q�$	��Top=�$��Verdana)�$��14(�$��1���� $��=��$
��Left=�$��-128,37,0,-8q�$	��Top=�$��Verdana)�$��14(�$��1���� $��Área total��$
��Left=�$��55,400,0,-134q�$��Verdana)�$��14(��� $��Área total��$
��Left=�$��55,431,0,-165q�$��Verdana)�$��14(��� -    ��Name$ 
Resultado1��$��Verdana)�$��14(�$�� ��$
��Left=�$��35��$��180,430,0,0q�$	��Top=�$	��142���� -   $��Calcular área total��$
��Left=�$��54��$��105,465,0,0q�$	��Top=�$	��171��$��Verdana)�$��14(����	#FFDAE6F0$��4q����	#FF2F463C���	#FFFBFBFB$
��Bold"�