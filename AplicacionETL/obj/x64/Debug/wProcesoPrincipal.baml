   M S B A M L   `   `   `  ����  AplicacionETL%    AplicacionETL.wProcesoPrincipal   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Ejecución ETL -Detectta ��5   	    � 
ResizeMode$ NoResize=�6E   $��244.579��6[   $	��523��6l    � Icon$ Imagenes/CM.ico��6x   ���	#FFDCDCE2 � WindowStartupLocation$ CenterScreen=�6�   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��138* �6   �� 5      $��9* �6   �� 5	      $	��13* �6   �� 5
      $
��124* �6   �� 5      $
��233* �6   .+�5   
   �� -   5        $��btnEjecutar��5   ,    � ToolTip$ Ejecutar Proceso��6   $��Ejecutar��6[   $
��Left=�6n   $��
22,172,0,0q�6�   $	��Top=�6�   $	��127��6�    J� RenderTransformOrigin$ 0.568,1.124&�6�   $��24��6�   $��4��6�   �� 5   
   -   5        $��txtProcesoTemporal��5       �� 
IsReadOnly . $
��Left=�6?   $��24��6Z   $��
39,172,0,0q�6f    �� TextWrapping$
 Wrap=�6z   $!��Proceso Ejecución Temporal��6�   $	��Top=�6�   $	��235��6�   $��4��6�   �� 5   
   $��	ExtraBold"�6   $!��Ejecución Paquete Detectta��6'   $
��Left=�6L   $��8,9,0,0q�6g   $	��Top=�6x   $	��180��6�   $��3��6�   $��2��6�   �� 5   
   -   5        $��imgTemporal��5      $
��Left=�6#   $��24��6>   $��166,172,0,0q�6J   $	��Top=�6_   $��45��6w   $��4��6�   �� 5   
   -   5        $��
imgProceso��5      $
��Left=�6"   $��24��6=   $��166,172,0,0q�6I   $	��Top=�6^   $��45��6v   $��4��6�   �� 5   
   $��Imagenes/cmacica.gif��6   $
��Left=�6.   $��39��6I   $��38,9,0,0q�6U   $	��Top=�6g   $��74��6   �� 5   
   $��Usuario��6   $��	ExtraBold"�6"   $
��Left=�69   $��24��6T   $��	19,53,0,0q�6`   $	��Top=�6s   $��62��6�   �� 5   
   $	��PC:��6   $��	ExtraBold"�6   $
��Left=�65   $��	34,53,0,0q�6P   $	��Top=�6c   $��62��6{   $��3��6�   �� 5   
   -   5        $��txtUser��5       . $
��Left=�64   $��23��6O   $��	72,53,0,0q�6[   $
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $��91��6�   $��4��6�   �� 5   
   -   5        $��txtPc��5   $    . $
��Left=�62   $��23��6M   $��	65,53,0,0q�6Y   $
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��227��6�   $��3��6�   $��2��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��dtFechaInicio��5      $��31,112,28,0q�6m   $	��Top=�6�   $��4��6�     5   
   -	   5        $��
dtFechaFin��5      $
��Left=�6c   $��
12,112,0,0q�6~   $	��Top=�6�   $	��211��6�   $��4��6�   5      5      