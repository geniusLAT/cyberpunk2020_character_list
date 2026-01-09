using Cyberpunk2020CharacterManager_network.Records;

namespace Cyberpunk2020CharacterManagerServer.Services.Interfaces;

public interface IUserReader
{
    Task<IEnumerable<ServerUserDto>> ReadUsers();
}
