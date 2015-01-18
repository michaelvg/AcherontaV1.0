#pragma strict

var oParticipant : Transform;

function OnNetworkLoadedLevel () {
// Instantiating Participantwhen Network is loaded 
Network.Instantiate(oParticipant, transform.position, transform.rotation, 0);
}
function OnPlayerDisconnected (player : NetworkPlayer) {
Network.RemoveRPCs(player, 0);
Network.DestroyPlayerObjects(player);
}