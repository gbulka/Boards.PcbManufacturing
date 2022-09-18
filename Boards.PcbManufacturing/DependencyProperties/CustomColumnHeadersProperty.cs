using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Boards.PcbManufacturing.DependencyProperties
{
    public static class CustomColumnHeadersProperty
    {
        public static DependencyProperty ItemTypeProperty = DependencyProperty.RegisterAttached(
            "ItemType",
            typeof(Type),
            typeof(CustomColumnHeadersProperty),
            new PropertyMetadata(OnItemTypeChanged));

        public static void SetItemType(DependencyObject obj, Type value)
        {
            obj.SetValue(ItemTypeProperty, value);
        }

        public static Type GetItemType(DependencyObject obj)
        {
            return (Type)obj.GetValue(ItemTypeProperty);
        }

        private static void OnItemTypeChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            var dataGrid = (DataGrid)sender;
            if (args.NewValue != null)
            {
                dataGrid.AutoGeneratingColumn += OnDataGridAutoGeneratingColumn;
            }
            else
            {
                dataGrid.AutoGeneratingColumn -= OnDataGridAutoGeneratingColumn;
            }
        }

        static void OnDataGridAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            var type = GetItemType((DataGrid)sender);
            var displayAttribute = type
                .GetProperty(e.PropertyName)
                .GetCustomAttributes(typeof(DisplayAttribute), false)
                .FirstOrDefault() as DisplayAttribute;
            if (displayAttribute != null)
            {
                e.Column.Header = displayAttribute.Name;
            }
        }
    }
}
