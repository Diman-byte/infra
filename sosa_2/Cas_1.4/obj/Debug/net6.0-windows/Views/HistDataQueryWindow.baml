   M S B A M L   `   `   `  ����B  >Cas_1.4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Cas_1._4.ViewsCas_1._4.Views  5      9!clr-namespace:Cas_1._4.ViewModelsCas_1._4.ViewModels  5      (    "Cas_1._4.Views.HistDataQueryWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Cas_1._4.Views     5      9viewsmodels!clr-namespace:Cas_1._4.ViewModels     5      .��5      � 
��� � �  � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $��	Database:��6   �� 5      -   5         ��Name$ databaseTextBox��5      $	��200��6/   �� 5      $��Node ID:��6   $
��10,0q�6'   �� 5      -   5        $ nodeIdTextBox��5      $	��100��6-   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   .+�5      �� $#��С какого месяца:��6   �� 5      -   5        $ DataTimeBeginTextBox��5      $	��100��64   �� 5       $%��До какого месяца:��6   $
��10,0q�60   �� 5!      -   5        $ DataTimeEndTextBox��5!      $	��100��62   5"      �� 5$   
   $��2��6   $ 
Horizontal=�6"   .+�5%      �� $��С какого Tag ID:��6   �� 5&      -   5        $ idTagsFromTextBox��5&      $��50��61   �� 5'      $��По какой Tag ID:��6   �� 5(      -   5        $ idTagsToTextBox��5(      $��50��6/   �� 5)      $0��*Max Rows (пока не работает):��6   $
��10,0q�6;   �� 5*      -   5        $ maxRowsTextBox��5*      $	��100��6.   �� 5+      -   5        $��Query��5+      $
��25,0q�6%   63   5,      &   System.Windows.Controls.DataGrid  5.   
   -	   5          Name$ resultsDataGrid��5.      $��3��6,      AutoGenerateColumns$ False��69      CanUserAddRows$ False��6U      Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ Tag ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *TagId+  51      $ DateTime��6%    67   �� *
DateTime+4  .System.Windows.Controls.DataGridCheckBoxColumn  52      $ Is Good��6)    6:   �� *IsGood+  53      $ Value��6%    64   �� *Value+55      59      5:      