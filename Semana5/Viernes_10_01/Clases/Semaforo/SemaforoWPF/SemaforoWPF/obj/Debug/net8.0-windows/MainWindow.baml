   M S B A M L   `   `   `  ����F  BSemaforoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SemaforoWPFSemaforoWPF  5   	       SemaforoWPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SemaforoWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��75 �6   6*   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   .+�5      �� $��SEMAFORO��6   $��50(�6(   $��Center=�5      
���/���5   3   5      �� 5   
   $��1��6   .+�5      �  � ColumnDefinitions 5      �� 5      $
��0.5* �6'   66   �� 5      $
��0.5* �6'   66   5      �� 5      $��0��6   .+�5      	� -   5        $��RadioButtonRojo��5   7   $��50, 20, 100, 80q�6   .��5      �� $
��Rojo��6    $��30(�6,   6<   5       	� 5"      -   5        $��RadioButtonAmarillo��5"   7   $��50, 20, 100, 80q�6   .��5#      �� $��Amarillo��6    $��30(�60   6@   5$      	� 5&      -   5        $��RadioButtonVerde��5&   7   $��50, 20, 100, 80q�6   .��5'      �� $��Verde��6    $��30(�6-   6=   5(      5)      � 5+      $��1��6    5,      �� 5-      $	��97* �6'   �� 5.      $	��63* �6'   .+�50      �� $l��fC:\DiskD\CodigoTecsup\C#\Clases\semana5_WPF\clase2\1.Elementos\7.ProyectRadioButton-Image\semaforo.jpg��6   $	��300��6�   $	��300��6�   $��476,-398,24,398q�6�   $��2��6�   6�   A� 51      -   5        $��
ElipseRoja��51   %   
���  ��$y�Hidden=�67   $��122,-361,143,611q�6K   $��1��6e   A� 52      -   5        $��ElipseAmarilla��52   (   
��� ���$y�Hidden=�6>   $��122,-305,143,555q�6R   $��1��6l   A� 53      -   5        $��ElipseVerde��53   '   
��� � �$y�Hidden=�6:   $��121,-251,141,501q�6N   $��1��6h    J� RenderTransformOrigin$ 
0.36,2.167&�6x   54      55      57      58      