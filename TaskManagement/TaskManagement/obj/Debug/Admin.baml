   M S B A M L   `   `   `  ����I  ETaskManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TaskManagementTaskManagement  5          TaskManagement.Admin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:TaskManagement     5        N� Title$  Admin��5	      .��5
      �� .��5   
   � ��5      �� 5       �� ImageSource$ /images.jpg��6    � RowDefinitions 5      �� 5      $��70 �6    �� 5      $��70 �6    �� 5      $��70 �6    �� 5      $��70 �6    �� 5      $
��auto �6    .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6&   .+�5      �� $��Task ID��6   $	��100��6*   $��25(�66   $
��30 0q�6D   $��40��6S   �� 5      -   5        $��	taskidtxt��5      $	��100��6,   $��25(�68   $
��30 0q�6F   $��40��6U   �� 5      $��Status��6   $	��100��6)   $��25(�65   $
��30 0q�6C   $��40��6R   �� 5      -   5        $��adStatusCombo��5      $	��150��60   $��40��6<   .@�5      �� $��	Completed��6#   �� 5      $��Pending��6#   �� 5      $��In Progress��6#   5      5      �� 5!      $��1��6   $ 
Horizontal=�6&   .+�5"      �� $��Title��6   $	��100��6(   $��25(�64   $
��30 0q�6B   $��40��6Q   �� 5#      -   5        $��titletxt��5#      $	��100��6+   $��25(�67   $
��30 0q�6E   $��40��6T   �� 5$      $��Email��6   $	��100��6(   $��25(�64   $
��30 0q�6B   $��40��6Q   �� 5%      -   5        $��emailtxt��5%      $	��100��6+   $��25(�67   $
��30 0q�6E   $��40��6T   5&      �� 5(      $��2��6   $ 
Horizontal=�6&   .+�5)      �� $��Description��6   $	��200��6.   $��25(�6:   $
��30 0q�6H   $��40��6W   �� 5*      -   5        $��desctxt��5*      $	��200��6*   $��25(�66   $
��30 0q�6D   $��40��6S   5+      �� 5-      $��3��6   $ 
Horizontal=�6&   .+�5.      �� -   5        $
��AddB��5.      $	��Add��6%   $
��50 0q�63   $	��100��6A   $��50��6M   $��28(�6Y   6g   �� 5/      -   5        $��EditB��5/      $
��Edit��6&   $��100 0q�65   $	��100��6D   $��50��6P   $��28(�6\   6j   �� 50      -   5        $
��DelB��50      $��Delete��6%   $��100 0q�66   $	��100��6E   $��50��6Q   $��28(�6]   6k   51      �� 53      $��5��6   .+�54      &   System.Windows.Controls.DataGrid  -	   5          Name$ adminDG��54         AutoGenerateColumns .     Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ Employee email��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6d   	   FontSize$	 10Q�6n   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6E   �� *
User.Email+6n     57      $ Task ID��6-   $ * 6Y   $	 10Q�6c   
 6>   �� *TaskId+6c     58      $ Title��6-   $ * 6V   $	 10Q�6`   
 6<   �� *Title+6`     59      $ Description��6-   $ * 6b   $	 10Q�6l   
 6B   �� *Description+6l     5:      $ Status��6-   $ * 6X   $	 10Q�6b   
 6=   �� *Status+6b   5<      5=      5>      5?      5@      