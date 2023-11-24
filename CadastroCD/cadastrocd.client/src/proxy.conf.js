const PROXY_CONFIG = [
  {
    context: [
      "/cd",
    ],
    target: "https://localhost:7179",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
