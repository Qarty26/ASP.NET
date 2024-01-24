namespace Roads.Services.UserTrackCarService
{
    public interface IUserTrackCarService
    {
        Task AddTrackWithCarToUser(Guid idTrack, Guid idCar, Guid idUser);
    }
}
