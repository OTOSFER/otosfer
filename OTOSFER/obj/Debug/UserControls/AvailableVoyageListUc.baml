   M S B A M L   `   `   `  ����B  >OTOSFER, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:OTOSFER.UserControlsOTOSFER.UserControls  5      0    *OTOSFER.UserControls.AvailableVoyageListUc   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:OTOSFER.UserControls     5      -   5          >�Name$  avluc��5      
�������.��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AvailableVoyageListdg��5
   ,   $	��600��6   $	��800��6       RowBackground
 � ���   AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .     CanUserSortColumns .     CanUserResizeRows .     
IsReadOnly . 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Sefer No��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ��  �� Path$	 sno�   ClipboardContentBinding 6T   Z�   5      $
 	Güzergah��6%    67   �� $	 gzg� 6U   Z�   5      $
 Tarih ve Saat��6%    6<   �� $	 tvs� 6Z   Z�   5      $
 Yolcu Kapasitesi��68    6%   Z�  6R   Z�   5      $
 	Kaptan Ad��68    6%   Z�  6K   Z�   5      $
 Plaka��68    6%   Z�  6G   Z�   5      $
 Bilet Fiyatı��68    6%   Z�  6N   Z� 5      5      5      