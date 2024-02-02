using AdministradorTareas.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewDem.Selectors
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product = item as Tarea;
            if (!product.Completa)
            {
                Application.Current.Resources.TryGetValue("normal", out var normal);
                return normal as DataTemplate;
            }
            else
            {
                Application.Current.Resources.TryGetValue("tachado", out var tachado);
                return tachado as DataTemplate;
            }
            return new DataTemplate();
        }
    }


}
    

