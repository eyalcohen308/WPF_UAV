   M S B A M L   `   `   `  ����J  FFlightSimulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FlightSimulator.ViewsFlightSimulator.Views  5      "    FlightSimulator.Views.Manual   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FlightSimulator.Views     5      .��5	      � $	��430��6   $	��470��6     � ColumnDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��ThrottleLabel��5      $��0��6)   $��2��69   $��Center=�6F   $��← thorttel →��6a   $��15(�6u    � LayoutTransform 5      �� 5       �� Angle$ 90Q�6"   5      �� 5   
   -   5        $��ThrottleSlider��5      $��2��6'   $��1��64    � Minimum$ -1Q�6e    � Maximum$ 1Q�6r   $��29��6~    �� TickPlacement$ TopLeft=�6�    �� TickFrequency$	 0.1Q�6�    �� Orientation$ Vertical=�6�   	 � Value	 6D   �� *ChangeThrottle+6�   �� 5   
   -   5        $��ThrottleVal��5      $��1��6'   $��1��64   ��6D   �� 
 �� ElementName$
 ThrottleSlider�� �� Path$ Value� �� StringFormat$ N2��6�   $   FlightSimulator.Views.Joystick  5!   
   -   5          Name$ Stick��5!      $��2��6(   $��2��65   $��Center=�6E   $��Center=�6`      Aileron 6}   �� *ChangeAileron+ �� Mode$ OneWayToSource=�   Elevator 6�   �� *ChangeElevator+$ OneWayToSource=�6�   �� 5#   
   -   5        $��RudderLabel��5#      $��2��6(   $��4��68   $��← rudder →��6E   $��15(�6W   $��Center=�6e   6�   �� 5$   
   -   5        $��RudderSlider��5$      $��3��6%   $��2��62   $��25��6B   $ -1Q�6N   $ 1Q�6[   $ BottomRight=�6�   $	 0.2Q�6�   	 6g   �� *ChangeRudder+6�   �� 5%   
   -   5        $��	RudderVal��5%      $��3��6%   $��3��62   ��6B   �� $
 RudderSlider��$ Value�$ N2��6�   �� 5(   
   -   5        $��ElevatorLabel��5(      $��2��6*   $��4��67   $��← elevator →��6H   $��15(�6\   $��Center=�6j    5)      �� 5*      $ 90Q�6"   5,      �� 5-   
   -	   5        $��ElevatorVal��5-      $��1��6'   $��4��64   $��40��6D   ��6O   �� $
 Stick��$ Elevator�$ N2�� 5.      �� 5/      $ 90Q�6"   51      �� 52   
   -
   5        $��AileronLabel��52      $��0��6(   $��2��65   $��← aileron →��6G   $��15(�6Z   $��Center=�6h   6�   �� 53   
   -   5        $��
AileronVal��53      $��0��6&   $��3��63   $��40��6C   ��6N   �� $
 Stick��$ Elevator�$ N2��6�   54      55      