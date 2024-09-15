using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace test_maui_app.ViewModels;

public class CartViewModel : BaseViewModel
{
    private ObservableCollection<int> _items;
    private int _itemsCount=0;

    public CartViewModel()
    {
        _items = [];
        Items.CollectionChanged+=OnItemsChanged;
    }

    private void OnItemsChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                break;
            case NotifyCollectionChangedAction.Remove:
                break;
            case NotifyCollectionChangedAction.Reset:
                break;
        }

        ItemsCount = _items.Count;
    }

    public ObservableCollection<int> Items
    {
        get => _items;
        set => SetProperty(ref _items, value);
    }

    public int ItemsCount
    {
        get => _itemsCount;
        set => SetProperty(ref _itemsCount, value);
    }
}
