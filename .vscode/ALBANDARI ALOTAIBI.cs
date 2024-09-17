internal class Program
{
    private static void Main(string[] args)
    {
        {
            "include": [
              "src"
            ],

  "exclude": [
    "**/node_modules",
    "**/__pycache__",
    "src/experimental",
    "src/typestubs"
  ],

  "ignore": [
    "src/oldstuff"
  ],

  "defineConstant": {
                "DEBUG": true
  },

  "stubPath": "src/stubs",

  "reportMissingImports": "error",
  "reportMissingTypeStubs": false,

  "pythonVersion": "3.6",
  "pythonPlatform": "Linux",

  "executionEnvironments": [
    {
                "root": "src/web",
      "pythonVersion": "3.5",
      "pythonPlatform": "Windows",
      "extraPaths": [
        "src/service_libs"
      ],
      "reportMissingImports": "warning"
    },
    {
                "root": "src/sdk",
      "pythonVersion": "3.0",
      "extraPaths": [
        "src/backend"
        
      ]
    },
    {
                "root": "src/tests",
      "extraPaths": [
        "src/tests/e2e",
        "src/sdk"
      ]
    },
    {
                "root": "src"
    }
  ]
}/ Users / albandarialotaibi / Desktop / CIT / ALBANDARI ALOTAIBI.css}
}