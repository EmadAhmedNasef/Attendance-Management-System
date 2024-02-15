<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <head>
        <title>Class Records</title>
        <style>
          table {
            border-collapse: collapse;
            width: 100%;
          }
          th, td {
            border: 1px solid black;
            padding: 8px;
            text-align: left;
          }
          th {
            background-color: #f2f2f2;
          }
        </style>
      </head>
      <body>
        <h2>Class Records</h2>
        <table>
          <thead>
            <tr>
              <th>Date</th>
              <th>Student Name</th>
              <th>Student ID</th>
              <th>Status</th>
            </tr>
          </thead>
          <tbody>
            <xsl:apply-templates select="//students"/>
          </tbody>
        </table>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="students">
    <xsl:for-each select="student">
      <tr>
        <td><xsl:value-of select="../date"/></td>
        <td><xsl:value-of select="studentname"/></td>
        <td><xsl:value-of select="studentID"/></td>
        <td><xsl:value-of select="status"/></td>
      </tr>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
