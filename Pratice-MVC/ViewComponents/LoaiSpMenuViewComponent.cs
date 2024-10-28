using Microsoft.AspNetCore.Mvc;
using Practive_MVC.Repository;
namespace Practive_MVC.ViewComponents
{
    public class LoaiSpMenuViewComponent : ViewComponent
    {
        private readonly IloaiSpRepository _loaiSp;
        public LoaiSpMenuViewComponent(IloaiSpRepository loaiSpRepository)
        {
            _loaiSp = loaiSpRepository;
        }
        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSp.GetAllLoaiSp().OrderBy(x => x.Loai);
            return View(loaisp);
        }
    }

}
