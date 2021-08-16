const {lstPortals} = require("./constants/typecd");

var settings = {
  common: {
    test: 1
  }
};

var portalConfigPath, portalConfig;

lstPortals.map((portal)=>{
  portal = "myperfectcoverletter.com";
  portalConfigPath = "./portal-config/" + portal + "/config.json";
  portalConfig = require(portalConfigPath);
  settings[portal] = portalConfig;
});

module.exports = {
  env: {
    settings: settings
  }
};
