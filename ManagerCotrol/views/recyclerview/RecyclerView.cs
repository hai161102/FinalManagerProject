using ManagerProjectDotNet.base_app.linear;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.views.recyclerview
{
    public abstract class RecyclerView<T> : LinearLayout, IDataGridViewEditingControl, IList<T>
    {
        private List<T> list;
        private int listSize;
        protected RecyclerView(string width, string height, Control parent, Orientation orientation, List<T> listItems) : base(width, height, parent)
        {
            this.orientation = orientation;
            this.list = listItems;
            getViewObject(parent);
            listSize = getItemCount();
        }

        protected abstract Panel getViewObject(Control parent);
        
        protected abstract int getItemCount();

        protected abstract void onViewHolder(T holder, int position);

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DataGridView EditingControlDataGridView { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object EditingControlFormattedValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int EditingControlRowIndex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EditingControlValueChanged { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Cursor EditingPanelCursor => throw new NotImplementedException();

        public bool RepositionEditingControlOnValueChange => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
        }

        public void Clear()
        {
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            throw new NotImplementedException();
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            list.Insert(index, item);
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
