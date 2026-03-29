using Microsoft.EntityFrameworkCore;
using Booking.Models;

namespace Booking.Data
{
    public class BookingDbContext : DbContext
    {

        public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options) { }

        public DbSet<Hotel> Hotels => Set<Hotel>();
        public DbSet<Room> Rooms => Set<Room>();
        public DbSet<Booking.Models.Booking> Bookings => Set<Booking.Models.Booking>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Review> Reviews => Set<Review>();
        public DbSet<FavoriteHotel> FavoriteHotels => Set<FavoriteHotel>();
    }
}
