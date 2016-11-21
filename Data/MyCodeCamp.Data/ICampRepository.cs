using System.Collections.Generic;
using System.Threading.Tasks;
using MyCodeCamp.Data.Entities;

namespace MyCodeCamp.Data
{
  public interface ICampRepository
  {
    // Basic DB Operations
    void Add<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    Task<bool> SaveAllAsync();

    // Camps
    IEnumerable<Camp> GetAllCamps();
    Camp GetCamp(int id);
    Camp GetCampWithSpeakers(int id);
    Camp GetCampByMoniker(string moniker);
    Camp GetCampByMonikerWithSpeakers(string moniker);

    // Speakers
    IEnumerable<Speaker> GetSpeakers(int id);
    IEnumerable<Speaker> GetSpeakersWithTalks(int id);
    IEnumerable<Speaker> GetSpeakersByMoniker(string moniker);
    IEnumerable<Speaker> GetSpeakersByMonikerWithTalks(string moniker);
    Speaker GetSpeaker(int speakerId);
    Speaker GetSpeakerWithTalks(int speakerId);

    // Talks
    IEnumerable<Talk> GetTalks(int speakerId);
    Talk GetTalk(int talkId);

    // CampUser
    CampUser GetUser(string userName);
  }
}