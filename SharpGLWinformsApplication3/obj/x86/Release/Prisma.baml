   M S B A M L   `   `   `  ����   SharpGLWinformsApplication3    MiniPaint.Prisma   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     \ XHelixToolkit.Wpf, Version=2015.1.558.0, Culture=neutral, PublicKeyToken=52aa3500039caf0d$hhttp://helix-toolkit.org/wpf  $	��378��.��� $	��529��$	��378��  � RowDefinitions  �� $
��492* ��� $	��37* �.+�&   HelixToolkit.Wpf.HelixViewport3D  -     Name$ camera�� J� Opacity$	 0.8Q�$
��Left=�$	��618��   ShowCameraTarget .     ShowViewCube .  $��-118,60,-122,62q�   ChangeFieldOfViewCursor$ No��   RotateCursor$
 Hand�� J� 	AllowDrop .  J� RenderTransformOrigin$ 0.561,0.509&�	   RotateGesture	 b� 
 b� MouseAction$
 	LeftClicke� b� 	Modifiers$  f�   Children. (  "HelixToolkit.Wpf.CuttingPlaneGroup  .2�g�  g� Content h� .���  � Geometry k� -   mesh�� k� 	PositionsY �   �� �^���6 �� �^������� `y���� �����6 �^�����`�
  k� Normalsy �   �� ����M�7�Q��?���� �� ��&>���� ��_ �� ����M�7�Q������ a����&>��d��O �� k� TriangleIndices. �$        � Material u�  u� Brush
 ��� � � BackMaterial u� 
 ��ح� j� 	Transform ��  �� Rotation ��  �� Axis$ 0 1 05� �� Angle ��  �� ElementName$
 horz�� �� Path$ Value���  �� Color$
 Gray��t� $ Green�� t� 	Direction$ 2 -3 -15�� $
��Left=�$	��192��$��-90,110,0,0q�$	��Top=�$	��280��.+�� -    �Name$ gradeconfirmacao��$
��Left=�$	��162��$��96,264,-200,-234q�$	��Top=�$	��384��.+��� $:��4       Selecione um valor para raio e altura da base��$
��Left=�$��32��$��0,10,0,0q�$	��Top=�$��Verdana)�$��14(�$	��374���� -    ��Name$ texto��$
��Left=�$��26��$��Verdana)�$��14(�$��	97,59,0,0q�$	��Top=�$	��145��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� -    ��Name$ botaoAT2��$��	Confirmar��$
��Left=�$��46��$��	74,98,0,0q�$	��Top=�$	��195��$��Verdana)�$��14(�
����  �$��4q����	#FF2F463C���	#FFFBFBFB$
��Bold"�� -   $ 
gradesetor��$
��Left=�$	��282��$��10,263,-152,-16q�$	��Top=�$	��520��$��2��.+��� $��V��$
��Left=�$��	10,38,0,0q�$	��Top=�$��Verdana)�$��14(��� $��=��$
��Left=�$��	35,38,0,0q�$	��Top=�$��Verdana)�$��14(��� $
��Base��$
��Left=�$��	61,38,0,0q�$	��Top=�$��Verdana)�$��14(��� $��*��$
��Left=�$��	99,40,0,0q�$	��Top=�$��Verdana)�$��14(��� $��AB��$
��Left=�$��
118,38,0,0q�$	��Top=�$��Verdana)�$��14(��� $��V��$
��Left=�$��	10,78,0,0q�$	��Top=�$��Verdana)�$��14(��� $��=��$
��Left=�$��	35,78,0,0q�$	��Top=�$��Verdana)�$��14(��� $��*��$
��Left=�$��
137,81,0,0q�$	��Top=�$��Verdana)�$��14(��� -     ��Name$  alt_base��$
��Left=�$��23��$��
167,82,0,0q�! �� TextWrapping$
! Wrap=�$	��Top=�$��62��$��Verdana)�$��14(�{�.  �� $��)��$
��Left=�$��
234,79,0,0q�$	��Top=�$ -0.105,0.308&�$��Verdana)�$��14(��� $��V��$
��Left=�$��
10,113,0,0q�$	��Top=�$��Verdana)�$��14(��� $��=��$
��Left=�$��
35,113,0,0q�$	��Top=�$��Verdana)�$��14(��� -   " ��Name$" raiovezesalturabase��$�� ��$
��Left=�$��
67,113,0,0q�$	��Top=�$��61��$��Verdana)�$��14(��� $��*��$
��Left=�$��143,114,0,0q�$	��Top=�$��Verdana)�$��14(��� -	   $" 
alt_prisma��$�� ��$
��Left=�$��174,113,0,0q�$	��Top=�$��61��$��Verdana)�$��14(��� $��V��$
��Left=�$��
10,145,0,0q�$	��Top=�$��Verdana)�$��14(��� $��=��$
��Left=�$��
35,145,0,0q�$	��Top=�$��Verdana)�$��14(��� -
   $	" Res��$�� ��$
��Left=�$��
67,145,0,0q�$	��Top=�$	��108��$��Verdana)�$��14(��� -   $ botaoAT��$+��%       Calcular Volume               ��$
��Left=�$��54��$��
99,197,0,0q�$	��Top=�$	��195��$��Verdana)�$��14(�
����  �$��4q����	#FF2F463C���	#FFFBFBFB$
��Bold"��� -   $
  raio��$
��Left=�$��23��$��	67,82,0,0q�$
! Wrap=�$	��Top=�$��62��$��Verdana)�$��14(�{�.  �� $��(��$
��Left=�$��	49,38,0,0q�$	��Top=�$��Verdana)�$��14(��� $��)��$
��Left=�$��
143,38,0,0q�$	��Top=�$��Verdana)�$��14(��� $��*��$
��Left=�$��
156,40,0,0q�$	��Top=�$��Verdana)�$��14(�$ 0.237,0.574&��� $��Altura do prisma��$
��Left=�$��
180,38,0,0q�$	��Top=�$��Verdana)�$��14(��� $��*��$
��Left=�$��
256,81,0,0q�$	��Top=�$��Verdana)�$��14(��� -   $ Altura��$
��Left=�$��26��$��Verdana)�$��14(�$��
280,81,0,0q�$	��Top=�$��64��.@��� $��1��$��Verdana)�$��14(�$��26��$	��100���� $��2��$��Verdana)�$��14(�$��26��$	��100���� $��3��$��Verdana)�$��14(�$��26��$	��100���� $��4��$��Verdana)�$��14(�$��26��$	��100���� $��5��$��Verdana)�$��14(�$��26��$	��100���� $��(��$
��Left=�$��	51,79,0,0q�$	��Top=�$ -0.105,0.308&�$��Verdana)�$��14(�