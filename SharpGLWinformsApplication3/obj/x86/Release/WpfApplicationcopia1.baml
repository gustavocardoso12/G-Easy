   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem   SharpGLWinformsApplication3$   MiniPaint.WpfApplicationcopia1   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  3System&clr-namespace:System;assembly=mscorlib    � 	Resources     MouseGesture1 b� MouseAction b� 	Modifiers  Double1  Double2  Boolean1  Boolean2��%�   &	        &	      &	 (     &	 3     &	 A     b� $ 
RightClicke�$  f�X�1Q�X�1Q���True����True��.��� $��	0,0,-80,0q�.+�&   HelixToolkit.Wpf.HelixViewport3D  -     Name$ camera�� J� Opacity$	 0.8Q�$
��Left=�$	��370��$��71,-100,-61,100q�   ChangeFieldOfViewCursor$ No��   RotateCursor$
 Hand�� J� 	AllowDrop .  �� AlternationCount$ 1����. $
��Auto=�$
��Auto=�	   ShowViewCube	 .  
 J� SnapsToDevicePixels
 .  J� RenderTransformOrigin$ 0.5,0.5&�   ShowCameraTarget .     IsInertiaEnabled .  !   IsChangeFieldOfViewEnabled .     RotateGesture b� $ 	LeftClicke�$  f�&   CoordinateSystemLabelForeground ��  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FFEE0404��$ 1Q�   Children. $  HelixToolkit.Wpf.DefaultLights  $  HelixToolkit.Wpf.LinesVisual3D  #  HelixToolkit.Wpf.CubeVisual3D  -   cubo��$  HelixToolkit.Wpf.MeshElement3D   Fill �	#FF01EB80$��RightToLeft=�   
SideLength$ 3Q��� $
��Left=�$	��100��$��-34,119,0,0q�$	��Top=�$	��100��� $
��Left=�$	��196��$��224,166,-134,-62q�$	��Top=�$	��290��.+��� $��Altura��$
��Left=�$��	4,143,0,0q�$	��Top=�$��Verdana)�$��14(��� -    ��Name$ textBox2��$
��Left=�$��23��$��
66,145,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��87��&   System.Windows.Media.TextOptions   TextHintingMode$ Animated=�$��Verdana)�$��14(���  J� IsHitTestVisible .  $
��(cm)��$��Center=�$
��Left=�$��158,149,0,31q�
�����������  �� 
TargetType" ��.���  �� Property � y� �� Value$ 	Collapsed=� �� Triggers ��   �� Binding  �� *Text+! �� ElementName$! textBox2��" �� Value"  .a���  � y�$ Visible=��� -   $ textBox3��$
��Left=�$��23��$��251,145,-50,0q�$
 Wrap=�$	��Top=�$��89��$��Verdana)�$��ExtraExpanded&�$ Animated=�$��14(��� $��Largura��$
��Left=�$��186,143,0,0q�$	��Top=�$��Verdana)�$��14(�$��Expanded&��� -   $ textBox1��$
��Left=�$��23��$��-121,146,0,0q�$
 Wrap=�$	��Top=�$��90��$ Animated=�$��Verdana)�$��14(���  .  $
��(cm)��$��Center=�$
��Left=�$��340,150,-73,30q�
����������� " ��.���  � y�$ 	Collapsed=� ��   �� *Text+$! textBox1��"  .a���  � y�$ Visible=���  .  $
��(cm)��$��Center=�$
��Left=�$��-26,150,0,30q�
����������� " ��.���  � y�$ 	Collapsed=� ��   �� *Text+$! textBox1��"  .a���  � y�$ Visible=��� $��Profundidade��$
��Left=�$��0,309,0,-43q�$��Verdana)�$��14(��� -   # ��Name$# 	Resultado��$�� ��$
��Left=�$��406,134,-188,0q�$	��Top=�$	��162��$��Verdana)�$	��128���� -   $$��Calcular Volume               ��$
��Left=�$��54��$��169,362,0,-116q�$	��Top=�$	��157��$��Verdana)�$��14(����	#FFDAE6F0$��4q�
����  ����	#FFFBFBFB$
��Bold"�