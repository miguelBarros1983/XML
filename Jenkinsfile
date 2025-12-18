pipeline {
    agent {
        label 'windows'
    }

    environment {
        SONAR_TOKEN = credentials('SONARQUBE_TOKEN')
    }

    stages {

        stage('Checkout') {
            steps {
                git branch: 'master',
                    url: 'https://github.com/miguelBarros1983/XML.git'
            }
        }

        stage('Prepare SonarQube') {
            steps {
                withSonarQubeEnv('SonarQube') {
                    bat """
                        dotnet-sonarscanner begin ^
                          /k:demo-app ^
                          /d:sonar.host.url=http://sonarqube:9000 ^
                          /d:sonar.token=%SONAR_TOKEN% ^
                          /d:sonar.exclusions=**/.vs/**,**/bin/**,**/obj/**
                    """
                }
            }
        }

        stage('Restore') {
            steps {
                bat 'dotnet restore PrsingXMLFile\\PrsingXMLFile.csproj'
            }
        }

        stage('Build') {
            steps {
                bat 'dotnet build PrsingXMLFile\\PrsingXMLFile.csproj --no-restore'
            }
        }

        stage('SonarQube End') {
            steps {
                withSonarQubeEnv('SonarQube') {
                    bat """
                        dotnet-sonarscanner end ^
                          /d:sonar.token=%SONAR_TOKEN%
                    """
                }
            }
        }

        stage('Quality Gate') {
            steps {
                timeout(time: 10, unit: 'MINUTES') {
                    waitForQualityGate abortPipeline: true
                }
            }
        }
    }
}
