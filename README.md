# Countries API

This project provides a set of APIs to retrieve information about countries, including country data, currency codes, phone codes, and more.

## Technologies Used

- C# 12.0
- .NET 8
- ASP.NET Core

## Getting Started

### Prerequisites

- .NET 8 SDK

### Installation

1. Clone the repository:
2. Navigate to the project directory:
3. Restore the dependencies:
### Running the Application

To run the application locally, use the following command:
The API will be available at `https://localhost:5001/api/countries`.

## API Endpoints

- `GET /api/countries/GetCountries` - Retrieves a list of all countries.
- `GET /api/countries/GetCountryData` - Retrieves detailed data for all countries.
- `GET /api/countries/GetCountryByCode?code={code}` - Retrieves country information by country code.
- `GET /api/countries/GetCountryByCurrencyCode?code={code}` - Retrieves country information by currency code.
- `GET /api/countries/GetCountryByPhoneCode?code={code}` - Retrieves country information by phone code.
- `GET /api/countries/GetCountryEmojiFlag?code={code}` - Retrieves the emoji flag for a country by country code.
- `GET /api/countries/GetCurrencyCodesByCountryCode?code={code}` - Retrieves currency codes by country code.
- `GET /api/countries/GetPhoneCodeByCountryShortCode?code={code}` - Retrieves phone code by country short code.
- `GET /api/countries/GetRegionByCountryCode?code={code}` - Retrieves region information by country code.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License

This project is licensed under the MIT License.
