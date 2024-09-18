using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLayer.Core.DTOs;

namespace NLayer.Repository.Repositories
{
    public class AlbumeRepository : GenericRepository<Albume>, IAlbumeRepository
    {
        private readonly AppDbContext _context;
        public AlbumeRepository(AppDbContext contex, AppDbContext context) : base(contex)
        {
            _context = context;
        }

        public async Task<List<AlbumeWithPicturesAndCommentsDto>> GetAlbumeWithPicturesAndCommentsAsync()
        {
            return await _context.Albumes
                .Select(a => new AlbumeWithPicturesAndCommentsDto
                {
                    Id = a.Id,
                    AlbumeName = a.AlbumeName,
                    Description = a.Description,
                    CoverPhoto = a.CoverPhoto,
                    AlbumeLike = a.AlbumeLike,
                    AlbumeDislike = a.AlbumeDislike,
                    Pictures = a.Pictures.Select(p => new Pictures
                    {
                        Id = p.Id,
                        PictureUrl = p.PictureUrl,
                        PictureLike = p.PictureLike,
                        PictureDislike = p.PictureDislike,
                        AlbumeId = p.AlbumeId,
                        PictureComments = a.Pictures.SelectMany(p => p.PictureComments.Select(pc => new PictureComments
                        {
                            Id = pc.Id,
                            Comment = pc.Comment,
                            CommentedBy = pc.CommentedBy,
                            PicturesId = pc.PicturesId
                        })).ToList()
                    }).ToList(),
                })
                .ToListAsync();
        }

        public async Task<List<Albume>> GetAlbumeWithPictures()
        {
            return await _context.Albumes.Include(x=> x.Pictures).ToListAsync();
        }

        public async Task<Albume> GetAlbumeWithPicturesById(int albumeId)
        {
            return await _context.Albumes.Include(x => x.Pictures).Where(x => x.Id == albumeId).FirstOrDefaultAsync();
        }
    }
}
