using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//sample file

/*
 * {
  "_": {
    "APP_ID": "server_tracked"
  },
  "success": true,
  "requestTime": "2013-08-10T05:46:35-07:00",
  "shard": "Brasil:N2M3Y2IwNzA4YmYzODQ0Nzc3N2VmZDE4NjAwMTI1MTlhZTg1YWVkMA",
  "player": {
    "accountId": 200604434,
    "summonerId": 2464675,
    "name": "Kingp1n",
    "icon": 28,
    "internalName": "kingp1n",
    "level": 30
  },
  "data": {
    "gameSpecificLoyaltyRewards": null,
    "reconnectDelay": 176,
    "dataVersion": 0,
    "libteemo": "1.0",
    "lastModifiedDate": null,
    "game": {
      "passwordSet": false,
      "spectatorsAllowed": "ALL",
      "gameType": "PRACTICE_GAME",
      "gameTypeConfigId": 1,
      "gameState": "IN_PROGRESS",
      "glmGameId": null,
      "glmHost": null,
      "observers": {
        "array": []
      },
      "statusOfParticipants": null,
      "glmSecurePort": 0,
      "ownerSummary": {
        "timeAddedToQueue": null,
        "index": 0,
        "accountId": 200604434,
        "queueRating": 0,
        "originalAccountNumber": 200604434,
        "botDifficulty": "NONE",
        "summonerInternalName": "kingp1n",
        "minor": false,
        "locale": null,
        "partnerId": "",
        "lastSelectedSkinIndex": 0,
        "profileIconId": 28,
        "teamOwner": false,
        "futureData": null,
        "summonerId": 2464675,
        "badges": 0,
        "pickTurn": 0,
        "dataVersion": 1,
        "clientInSynch": false,
        "selectedRole": null,
        "summonerName": "Kingp1n",
        "pickMode": 1,
        "originalPlatformId": "BR1",
        "selectedPosition": null,
        "teamParticipantId": null
      },
      "id": 120167517,
      "teamTwo": {
        "array": [
          {
            "botDifficulty": "NONE",
            "summonerInternalName": "bot_Nunu_200",
            "locale": null,
            "lastSelectedSkinIndex": 0,
            "teamId": "200",
            "futureData": null,
            "badges": 0,
            "dataVersion": 0,
            "pickTurn": 0,
            "botSkillLevel": 0,
            "spell2Id": null,
            "role": null,
            "summonerName": "Nunu bot",
            "pickMode": 0,
            "championId": null,
            "spell1Id": null
          },
          {
            "botDifficulty": "NONE",
            "summonerInternalName": "bot_FiddleSticks_200",
            "locale": null,
            "lastSelectedSkinIndex": 0,
            "teamId": "200",
            "futureData": null,
            "badges": 0,
            "dataVersion": 0,
            "pickTurn": 0,
            "botSkillLevel": 0,
            "spell2Id": null,
            "role": null,
            "summonerName": "FiddleSticks bot",
            "pickMode": 0,
            "championId": null,
            "spell1Id": null
          },
          {
            "botDifficulty": "NONE",
            "summonerInternalName": "bot_Sona_200",
            "locale": null,
            "lastSelectedSkinIndex": 0,
            "teamId": "200",
            "futureData": null,
            "badges": 0,
            "dataVersion": 0,
            "pickTurn": 0,
            "botSkillLevel": 0,
            "spell2Id": null,
            "role": null,
            "summonerName": "Sona bot",
            "pickMode": 0,
            "championId": null,
            "spell1Id": null
          }
        ]
      },
      "bannedChampions": {
        "array": []
      },
      "dataVersion": 0,
      "roomName": null,
      "name": "Partida de Kingp1n",
      "spectatorDelay": 180,
      "teamOne": {
        "array": [
          {
            "timeAddedToQueue": null,
            "index": 0,
            "accountId": 200604434,
            "queueRating": 0,
            "originalAccountNumber": 200604434,
            "botDifficulty": "NONE",
            "summonerInternalName": "kingp1n",
            "minor": false,
            "locale": null,
            "partnerId": "",
            "lastSelectedSkinIndex": 0,
            "profileIconId": 28,
            "teamOwner": false,
            "futureData": null,
            "summonerId": 2464675,
            "badges": 0,
            "pickTurn": 1,
            "dataVersion": 1,
            "clientInSynch": true,
            "selectedRole": null,
            "summonerName": "Kingp1n",
            "pickMode": 0,
            "originalPlatformId": "BR1",
            "selectedPosition": null,
            "teamParticipantId": null
          },
          {
            "botDifficulty": "NONE",
            "summonerInternalName": "bot_Chogath_100",
            "locale": null,
            "lastSelectedSkinIndex": 0,
            "teamId": "100",
            "futureData": null,
            "badges": 0,
            "dataVersion": 0,
            "pickTurn": 0,
            "botSkillLevel": 0,
            "spell2Id": null,
            "role": null,
            "summonerName": "Chogath bot",
            "pickMode": 0,
            "championId": null,
            "spell1Id": null
          },
          {
            "botDifficulty": "NONE",
            "summonerInternalName": "bot_Soraka_100",
            "locale": null,
            "lastSelectedSkinIndex": 0,
            "teamId": "100",
            "futureData": null,
            "badges": 0,
            "dataVersion": 0,
            "pickTurn": 0,
            "botSkillLevel": 0,
            "spell2Id": null,
            "role": null,
            "summonerName": "Soraka bot",
            "pickMode": 0,
            "championId": null,
            "spell1Id": null
          }
        ]
      },
      "terminatedCondition": "NOT_TERMINATED",
      "queueTypeName": "NONE",
      "glmPort": 0,
      "passbackUrl": null,
      "optimisticLock": 13,
      "roomPassword": "CIOH9ElXY1oqwAQo",
      "maxNumPlayers": 10,
      "queuePosition": 0,
      "futureData": null,
      "expiryTime": 2670678,
      "gameMode": "CLASSIC",
      "mapId": 1,
      "banOrder": null,
      "gameStateString": "IN_PROGRESS",
      "pickTurn": 3,
      "playerChampionSelections": {
        "array": [
          {
            "dataVersion": 0,
            "summonerInternalName": "kingp1n",
            "spell2Id": 21,
            "selectedSkinIndex": 0,
            "championId": 28,
            "futureData": null,
            "spell1Id": 4
          },
          {
            "dataVersion": 0,
            "summonerInternalName": "bot_Sona_200",
            "spell2Id": -1,
            "selectedSkinIndex": 0,
            "championId": 37,
            "futureData": null,
            "spell1Id": -1
          },
          {
            "dataVersion": 0,
            "summonerInternalName": "bot_Chogath_100",
            "spell2Id": -1,
            "selectedSkinIndex": 0,
            "championId": 31,
            "futureData": null,
            "spell1Id": -1
          },
          {
            "dataVersion": 0,
            "summonerInternalName": "bot_Nunu_200",
            "spell2Id": -1,
            "selectedSkinIndex": 0,
            "championId": 20,
            "futureData": null,
            "spell1Id": -1
          },
          {
            "dataVersion": 0,
            "summonerInternalName": "bot_Soraka_100",
            "spell2Id": -1,
            "selectedSkinIndex": 0,
            "championId": 16,
            "futureData": null,
            "spell1Id": -1
          },
          {
            "dataVersion": 0,
            "summonerInternalName": "bot_FiddleSticks_200",
            "spell2Id": -1,
            "selectedSkinIndex": 0,
            "championId": 9,
            "futureData": null,
            "spell1Id": -1
          }
        ]
      },
      "passbackDataPacket": null,
      "joinTimerDuration": 0
    },
    "connectivityStateEnum": null,
    "gameName": "partida de kingp1n",
    "playerCredentials": {
      "encryptionKey": null,
      "observerServerIp": "66.150.148.234",
      "playerId": 200604434,
      "handshakeToken": null,
      "dataVersion": 0,
      "serverPort": 0,
      "gameId": 120167517,
      "serverIp": null,
      "lastSelectedSkinIndex": 0,
      "observerServerPort": 80,
      "summonerName": null,
      "observerEncryptionKey": "ne/HwL7PpRQ2NYwt5fQj5rx44DoixhMg",
      "championId": 0,
      "observer": true,
      "futureData": null,
      "summonerId": 0
    },
    "_success": 1,
    "futureData": null
  }
}
 */

namespace LeagueOfLegendsAutoChat
{
    class IngameTO
    {
    }
}
