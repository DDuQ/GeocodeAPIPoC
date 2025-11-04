# Geocode API PoC

A serverless .NET application that provides geocoding services using Google's Geocoding API with AWS DynamoDB caching layer.

## Features

- **Geocoding Service**: Convert addresses into geographic coordinates using Google's Geocoding API
- **Caching Layer**: Built-in caching with AWS DynamoDB to reduce API calls and improve performance
- **Serverless Architecture**: Deployable as AWS Lambda functions with API Gateway
- **RESTful API**: Clean, consistent API endpoints for geocoding operations
- **Swagger Documentation**: Interactive API documentation for easy integration

## Tech Stack

- **Backend**: .NET 7.0+
- **Cloud Provider**: AWS
  - AWS Lambda for serverless compute
  - DynamoDB for caching geocoding results
  - AWS Secrets Manager for secure configuration management
- **APIs**:
  - Google Geocoding API for address geocoding
  - RESTful API with JSON payloads
- **Development Tools**:
  - Swagger/OpenAPI for API documentation
  - Built-in dependency injection
  - Environment-based configuration

## Project Structure

```
src/
├── GeocodeAPIPoC.Api/         # API endpoints and middleware
├── GeocodeAPIPoC.Application/ # Application logic and DTOs
├── GeocodeAPIPoC.Domain/      # Domain models and interfaces
└── GeocodeAPIPoC.Infrastructure/ # External service integrations and persistence
```

### Prerequisites

- .NET 7.0+ SDK
- AWS Account with appropriate permissions
- Google Cloud Platform account with Geocoding API enabled
- AWS CLI configured with credentials

### Configuration

1. Set up AWS Secrets Manager with the following secrets:
   ```
   [Environment]_GeocodeAPIPoC_Google__ApiKey=your_google_api_key
   [Environment]_GeocodeAPIPoC_AWS__Region=your_aws_region
   ```

2. Configure DynamoDB table for caching geocoding results

### Local Development

1. Clone the repository
2. Set up local development settings in `appsettings.Development.json`
3. Run the application:
   ```bash
   dotnet run --project src/GeocodeAPIPoC.Api
   ```
4. Access Swagger UI at `https://localhost:5001/swagger`

### Deployment

1. Build the application:
   ```bash
   dotnet publish -c Release -o ./publish
   ```
2. Deploy to AWS Lambda using AWS Toolkit for Visual Studio or AWS CLI

## API Endpoints

- `GET /api/location?address={address}` - Geocode an address
  - Returns: Geocoding results with coordinates and address components

## Caching Strategy

- Addresses are hashed and used as DynamoDB partition keys
- Results are cached to minimize API calls to Google Geocoding API
- Cache TTL can be configured based on your requirements

## Error Handling

- Standard HTTP status codes
- Detailed error messages in development mode
- Graceful degradation when external services are unavailable
