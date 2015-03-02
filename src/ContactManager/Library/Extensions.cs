using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
  public static partial class Extensions
  {
    public static void FillWithEnum<T>(this RepositoryItemLookUpEdit edit)
    {
      edit.ShowHeader = false;
      edit.DataSource = Enum.GetValues(typeof(T))
        .Cast<T>()
        .Select(t => new { Value = t, Display = t.ToString() })
        .ToList();
      edit.DisplayMember = "Display";
      edit.ValueMember = "Value";
      edit.Columns.Add(new LookUpColumnInfo("Display")
      {
        SortOrder = ColumnSortOrder.Ascending,
      });
    }

    public static T PopLast<T>(this IList<T> list)
    {
      int index = list.Count - 1;
      T value = list[index];
      list.RemoveAt(index);
      return value;
    }

    public static string GetDisplay(this ContactName name)
    {
      string[] values = new[] { name.First, name.Middle, name.Last };
      return string.Join(" ", values.Where(s => !string.IsNullOrWhiteSpace(s)));
    }
  }
}
