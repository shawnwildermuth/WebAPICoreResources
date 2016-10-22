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

    // Speakers
    IEnumerable<Speaker> GetSpeakers(int campId);
    IEnumerable<Speaker> GetSpeakersWithTalks(int campId);
    Speaker GetSpeaker(int speakerId);
    Speaker GetSpeakerWithTalks(int speakerId);

    // Talks
    IEnumerable<Talk> GetTalks(int speakerId);
    Talk GetTalk(int talkId);
  }
}