   M S B A M L   `   `   `  ����   RecipeAppGUI    RecipeApp.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
Recipe App��$	��450��$	��600��.���  � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto � � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� -    ��Name$ recipeListBox��$��20q����� .R��� $��16(����� *Name+�� $��1��$��0��$��20q�.+��� $��Selected Recipe��$��20(�$
��Bold"�$��0,0,0,10q��� -    ��Name$ selectedRecipeTextBlock��$��18(�$
��Bold"��� $��Ingredients:��$��16(�$��0,10,0,5q��� -   $ ingredientsListBox��$��0,0,0,10q����� .R��� .+��� $��14(����� *
Quantity+ �� StringFormat$ {0:F2}���� $��14(�$
��Bold"����� *Name+�� $��12(�$��Italic$����� *UnitOfMeasurement+�� $��Steps:��$��16(�$��0,0,0,5q��� -   $ stepsListBox��$��0q��� -   $ totalCaloriesTextBlock��$��14(�$��Italic$�$��0,10,0,0q��� $��2��$��0��$��20q�.+��� $��Update Recipe��$��20(�$
��Bold"�$��0,0,0,10q��� $��Ingredient Name:��$��16(�$��0,0,0,5q��� -    ��Name$ ingredientNameTextBox��$��14(��� $��	Quantity:��$��16(�$��0,10,0,5q��� -   $ ingredientQuantityTextBox��$��14(��� $��Unit of Measurement:��$��16(�$��0,10,0,5q��� -   $ ingredientUnitTextBox��$��14(��� -	   $��Add Ingredient��$��0,10,0,0q��� $��Step Description:��$��16(�$��0,10,0,5q��� -
   $ stepDescriptionTextBox��$��14(��� -   $��Add Step��$��0,10,0,0q��� $��2��$��1��$��20q�.+��� $��New Recipe Details��$��20(�$
��Bold"�$��0,0,0,10q��� $��Recipe Name:��$��16(�$��0,0,0,5q��� -   $ recipeNameTextBox��$��14(��� -   $��
Add Recipe��$��0,10,0,0q��� $��3��$��
Recipe App��$��24(�$
��Bold"�$��Center=�$
��0,20q��� $��2��$��0�� �� Orientation$ 
Horizontal=�$
��Left=�$��	20,0,0,20q�.+��� -   $��Delete Recipe��$��5q��� -    ��Name$ scaleComboBox��$	��100��$��5q�.@��� $	��0.5���� $��2���� $��3���� -   $��Scale Recipe��$��5q��� -   $��Reset to Previous Recipe��$��5q�