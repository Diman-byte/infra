   M S B A M L   `   `   `  ����B  >Cas_1.4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Cas_1._4.ViewsCas_1._4.Views  5   	   "    Cas_1._4.Views.ConnectDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Cas_1._4.Views     5   	     � Title$  Connect to Cassandra��5   	   $	��300��6&   $	��400��63   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Host:��6   �� 5   
   -   5         ��Name$ HostTextBox��5   *   $��0��6   $��5q�6   $	��200��6?   �� 5   
   $��1��6   $��Port:��6   �� 5   
   -   5        $ PortTextBox��5   *   $��1��6   $��5q�6   $	��200��6?   �� 5   
   $��2��6   $��Database Name:��6   �� 5   
   -   5        $ DatabaseTextBox��5   *   $��2��6   $��5q�6   $	��200��6C   �� 5   
   $��3��6   $��	Username:��6   �� 5   
   -   5        $ UserTextBox��5   *   $��3��6   $��5q�6   $	��200��6?   �� 5    
   $��4��6   $��	Password:��6   G� 5!   
   -   5         G�Name$ PasswordBox��5!   .   $��4��6   $��5q�6#   $	��200��6C   �� 5#   
   $��6��6   .@�5$      �� .��5%      �� -   5         ��Name$ StatusBarText��5%      $��Ready��63   5&      5'      �� 5)   
   $��7��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   .+�5*      �� -   5        $��Connect��5*      $��5q�6'   62   �� 5+      -   5        $��Cancel��5+      $��5q�6&   61   5,      5/      50      